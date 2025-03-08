using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Final_project_Website_Testing_
{
    [TestClass]
    public class AssemblySetup:BasePage
    {   
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            // Initialization logic for the entire assembly
            string ResultFile = @"C:\ExtentReports\TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".html";
            CreateReport(ResultFile);
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            // Cleanup logic for the entire assembly
           
            extentReports.Flush();
        }
    }
}
