using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;
using UiPath.CodedWorkflows;

namespace asycudabot.Service
{
    public class FindOutReceiptNumber : CodedWorkflow
    {
        [Workflow]
        public string Execute(string pdfPath)
        {
            pdfPath = NormalizePath(pdfPath);
            if (string.IsNullOrWhiteSpace(pdfPath))
                throw new ArgumentException("pdfPath was null or empty.", nameof(pdfPath));

            if (!File.Exists(pdfPath))
                throw new FileNotFoundException($"PDF not found at: {pdfPath}", pdfPath);

            var receipt = Parse(pdfPath);
            return receipt;
        }

        public static string Parse(string pdfPath)
        {
            using var doc = PdfDocument.Open(pdfPath);
            var page = doc.GetPage(1); // B ACCOUNTING DETAILS is always page 1

            var rows = BuildRows(page);

            var receipt = ExtractField(rows, "Receipt number");

            return receipt;
        }

        private static List<List<Word>> BuildRows(Page page, double yTolerance = 2.5)
        {
            var words = page.GetWords().ToList();
            var rows = new List<List<Word>>();

            foreach (var w in words.OrderByDescending(w => w.BoundingBox.Top))
            {
                var row = rows.FirstOrDefault(r =>
                    Math.Abs(r[0].BoundingBox.Top - w.BoundingBox.Top) <= yTolerance);
                if (row != null) row.Add(w);
                else rows.Add(new List<Word> { w });
            }

            foreach (var r in rows)
                r.Sort((a, b) => a.BoundingBox.Left.CompareTo(b.BoundingBox.Left));

            return rows;
        }

        private static string ExtractField(List<List<Word>> rows, string label)
        {
            var labelWords = label.Split(' ');

            foreach (var row in rows)
            {
                var text = string.Join(" ", row.Select(w => w.Text));
                if (!text.StartsWith(label, StringComparison.OrdinalIgnoreCase))
                    continue;

                // everything after the label words, up to "/" or "Date"
                var rest = row.Skip(labelWords.Length).ToList();
                var valueTokens = rest.TakeWhile(w => w.Text != "/" && w.Text != "Date").ToList();

                var value = string.Join(" ", valueTokens.Select(w => w.Text)).Trim();

                return string.IsNullOrWhiteSpace(value) ? null : value;
            }

            return null; // label not found at all
        }
        private static string NormalizePath(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                return path;

            // Handles "file:///C:/Users/..." -> "C:\Users\..."
            if (Uri.TryCreate(path, UriKind.Absolute, out var uri) && uri.IsFile)
                return uri.LocalPath;

            // Fallback: strip a literal "file:///" prefix if Uri parsing didn't catch it
            if (path.StartsWith("file:///", StringComparison.OrdinalIgnoreCase))
                return path.Substring("file:///".Length);

            return path;
        }
    }
}