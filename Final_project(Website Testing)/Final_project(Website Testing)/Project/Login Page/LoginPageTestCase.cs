using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Configuration;
using System;
using AventStack.ExtentReports;

namespace Final_project_Website_Testing_
{
    [TestClass]
    public class LoginPageTestCases:BasePage
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
           
           
            Test=extentReports.CreateTest(TestContext.TestName);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // Runs after each test method
        }

        #endregion

        #region Test Methods

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "main.xml", "LoginWithValidUserValidPass", DataAccessMethod.Sequential)]
        public void LoginWithValidUserValidPass()
        {
            Step = Test.CreateNode("LoginWithValidUserValidPass");
            PerformLoginTest();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "main.xml", "LoginWithInValidUserValidPass", DataAccessMethod.Sequential)]
        public void LoginWithInValidUserValidPass()
        {
            Step = Test.CreateNode("LoginWithInValidUserValidPass");

            PerformLoginTest();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "main.xml", "LoginWithValidUserInValidPass", DataAccessMethod.Sequential)]
        public void LoginWithValidUserInValidPass()
        {
            Step = Test.CreateNode("LoginWithInValidUserValidPass");
            PerformLoginTest();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "main.xml", "LoginWithInValidUserInValidPass", DataAccessMethod.Sequential)]
        public void LoginWithInValidUserInValidPass()
        {
            Step = Test.CreateNode("LoginWithInValidUserInValidPass");
            PerformLoginTest();
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "main.xml", "LoginWithValidUserValidPass", DataAccessMethod.Sequential)]
        public void logout()
        {
            Step = Test.CreateNode("logout");
            PerformLoginOut();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "main.xml", "LoginWithValidUserValidPass", DataAccessMethod.Sequential)]
        public void Bookeditinerary()
        {
            Step = Test.CreateNode("Bookeditinerary");
            Performbookhotel();
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "main.xml", "LoginWithValidUserValidPass", DataAccessMethod.Sequential)]
        public void cancelhotel()
        {
            Step = Test.CreateNode("cancelhotel");
            Cancelhotel();
        }
       
        
        #endregion

        #region Private Methods

        private void PerformLoginTest()
        {
            

            // Extract data from the test context
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();

            basePage.SeleniumInit();
            
                loginPage.Login(url, username, password);

               
                basePage.DriverClose();
            }
        
        private void PerformLoginOut()
        {
            // Extract data from the test context
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();

            // Initialize WebDriver and perform login
            basePage.SeleniumInit();
            loginPage.LoginOut(url, username, password);

            // Close WebDriver
            basePage.DriverClose();
        }
        private void Performbookhotel()
        {
            // Extract data from the test context
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();

            // Initialize WebDriver and perform login
            basePage.SeleniumInit();
            loginPage.BookedItinerary(url, username, password);

            // Close WebDriver
            basePage.DriverClose();
        }
    private void Cancelhotel()
    {
        // Extract data from the test context
        string url = TestContext.DataRow["url"].ToString();
        string username = TestContext.DataRow["username"].ToString();
        string password = TestContext.DataRow["password"].ToString();

        // Initialize WebDriver and perform login
        basePage.SeleniumInit();
        loginPage.CancelItem(url, username, password);

        // Close WebDriver
        basePage.DriverClose();
    }
        #endregion
    }
}
