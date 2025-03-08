using AventStack.ExtentReports.Model;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Final_project_Website_Testing_
{
    [TestClass]
    public class SearchhotelTestCases:BasePage
    {
        private SearchHotel searchotel = new SearchHotel();
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
            Test = extentReports.CreateTest(TestContext.TestName);
            // Runs before each test method
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // Runs after each test method
        }

        #endregion

        #region Test Methods

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "main.xml", "SearchHotelPositiveCase", DataAccessMethod.Sequential)]
        public void SearchHotelPositiveCase()
        {
            Step = Test.CreateNode("SearchHotelPositiveCase");

            PerformSearchTest();
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "main.xml", "SearchHotelemptyfieldforlocation", DataAccessMethod.Sequential)]
        public void SearchHotelemptyfieldforlocation()
        {
            Step = Test.CreateNode("SearchHotelemptyfieldforlocation");

            PerformSearchTest();
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "main.xml", "verifywhetherthecheckoutdatefieldacceptsalaterdatethancheckindate", DataAccessMethod.Sequential)]
        public void verifywhetherthecheckoutdatefieldacceptsalaterdatethancheckindate()
        {
            Step = Test.CreateNode("verifywhetherthecheckoutdatefieldacceptsalaterdatethancheckindate");

            PerformSearchTest();
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "main.xml", "Tocheckiferrorisdatefieldisinpast", DataAccessMethod.Sequential)]
        public void Tocheckiferrorisdatefieldisinpast()
        {
            Step = Test.CreateNode("Tocheckiferrorisdatefieldisinpast");

            PerformSearchTest();
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "main.xml", "roomscheck", DataAccessMethod.Sequential)]
        public void rommscheck()
        {
            Step = Test.CreateNode("rommscheck");

            PerformSearchTest();
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "main.xml", "verifythetotalpriceiscorrectaccordingthepricepernight", DataAccessMethod.Sequential)]
        public void verifythetotalpriceiscorrectaccordingthepricepernight()
        {
            Step = Test.CreateNode("verifythetotalpriceiscorrectaccordingthepricepernight");

            PerformSearchTest();
        }


        #endregion

        #region Private Methods

        private void PerformSearchTest()
        {
            // Extract data from the test context
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string location = TestContext.DataRow["location"].ToString();
            string hotel = TestContext.DataRow["hotel"].ToString();
            string roomtype = TestContext.DataRow["roomtype"].ToString();
            string numberOfRooms = TestContext.DataRow["room_nos"].ToString();
            string Indates = TestContext.DataRow["datepick_ins"].ToString();
            string Outdates = TestContext.DataRow["datepick_outs"].ToString();
            string adult_per_room = TestContext.DataRow["adult_room"].ToString();
            string children_per_room = TestContext.DataRow["child_room"].ToString();

            // Initialize WebDriver and perform login
            basePage.SeleniumInit();
            searchotel.Searchhotel(url, username, password, location, hotel, roomtype, numberOfRooms, Indates, Outdates, adult_per_room, children_per_room);

            // Close WebDriver
            basePage.DriverClose();
        }

        #endregion
    }
}
