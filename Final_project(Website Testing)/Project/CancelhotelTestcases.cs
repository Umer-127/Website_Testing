using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project_Website_Testing_
{
    [TestClass]
    public  class CancelhotelTestcases:LoginPage
    {
        private LoginPage loginPage = new LoginPage();
        private BasePage basePage = new BasePage();

        public TestContext TestContext { get; set; }
        public string ExecutionBrowser { get; private set; }

        #region Initializations and Cleanups

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            // Initialization logic for this test class
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            // Cleanup logic for this test class
        }

        [TestInitialize]
        public void TestInit()
        {
            // Runs before each test method


            Test = extentReports.CreateTest(TestContext.TestName);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // Runs after each test method
        }
        #endregion

        #region Testmethod

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "main.xml", "changepassword", DataAccessMethod.Sequential)]
        public void change_password()
        {
            Step = Test.CreateNode("change_password");
            ChangePassword();
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "main.xml", "newpasswordisdifferentfromconfirmpassword", DataAccessMethod.Sequential)]
        public void newpasswordisdifferentfromconfirmpassword()
        {
            Step = Test.CreateNode("newpasswordisdifferentfromconfirmpassword");
            ChangePassword();
        }
        #endregion


        #region method
        private void ChangePassword()
        {
            // Extract data from the test context
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string currentpassword = TestContext.DataRow["currentpassword"].ToString();
            string newpassword = TestContext.DataRow["newpassword"].ToString();
            string confirmpassword = TestContext.DataRow["confirmpassword"].ToString();

            // Initialize WebDriver and perform login
            basePage.SeleniumInit();
            loginPage.changepass(url, username, password, currentpassword, newpassword, confirmpassword);

            // Close WebDriver
            basePage.DriverClose();
        }
        #endregion
    }
}
