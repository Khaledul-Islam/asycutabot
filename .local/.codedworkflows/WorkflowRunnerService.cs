using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using asycutabot;

[assembly: WorkflowRunnerServiceAttribute(typeof(asycutabot.WorkflowRunnerService))]
namespace asycutabot
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the Helper/ConfigReader.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (string out_OutputFolder, string out_ExcelFileLocation) ConfigReader(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Helper\ConfigReader.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
            return ((string)result["out_OutputFolder"], (string)result["out_ExcelFileLocation"]);
        }

        /// <summary>
        /// Invokes the ReadExcelFile/ExcelFileData.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (string out_ExcelFileName, string out_errMsg, System.Data.DataTable out_LCList) ExcelFileData(string in_excelFileLocation, System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ReadExcelFile\ExcelFileData.xaml", new Dictionary<string, object> { { "in_excelFileLocation", in_excelFileLocation } }, default, isolated, default, GetAssemblyName());
            return ((string)result["out_ExcelFileName"], (string)result["out_errMsg"], (System.Data.DataTable)result["out_LCList"]);
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Main(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the RunProgram/OpenProgram.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void OpenProgram(string in_ExcelFileName, string in_excelFileLocation, string in_outputFolder, System.Data.DataTable in_LCListData, System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"RunProgram\OpenProgram.xaml", new Dictionary<string, object> { { "in_ExcelFileName", in_ExcelFileName }, { "in_excelFileLocation", in_excelFileLocation }, { "in_outputFolder", in_outputFolder }, { "in_LCListData", in_LCListData } }, default, isolated, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}