using System.Collections.Generic;

namespace asycutabot.Models
{
    public class WriteOffMemoryEntry
    {
        public string WriteOffId { get; set; }
        public bool IsDownloaded { get; set; }
        public bool IsReceipt { get; set; }
    }

    public class LcMemoryEntry
    {
        public string LCId { get; set; }
        public decimal LCValue { get; set; }
        public List<WriteOffMemoryEntry> WriteOffs { get; set; } = new List<WriteOffMemoryEntry>();
    }
}
