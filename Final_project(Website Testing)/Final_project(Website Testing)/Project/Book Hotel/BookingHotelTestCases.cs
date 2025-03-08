using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project_Website_Testing_.Project.Book_Hotel
{
    [TestClass]
    public class BookingHotelTestCases:BasePage
    {
        private Bookinghotel bookinghotel =new Bookinghotel();
        private BasePage basePage = new BasePage();
        public string ExecutionBrowser { get; private set; }

        public TestContext TestContext { get; set; }

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
        #region Test Methods
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "main.xml", "BookHotelpositivecase", DataAccessMethod.Sequential)]
        public void BookHotelpositivecase()
        {
            Step = Test.CreateNode("BookHotelpositivecase");

            PerformbookinghotelTest();
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "main.xml", "missingfirstname", DataAccessMethod.Sequential)]
        public void missingfirstname()
        {
            Step = Test.CreateNode("missingfirstname");

            PerformbookinghotelTest();
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "main.xml", "cardnoisincomplete", DataAccessMethod.Sequential)]
        public void cardnoisincomplete()
        {
            Step = Test.CreateNode("cardnoisincomplete");

            PerformbookinghotelTest();
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "main.xml", "cvvnocheck", DataAccessMethod.Sequential)]
        public void cvvnocheck()
        {
            Step = Test.CreateNode("cvvnocheck");

            PerformbookinghotelTest();
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "main.xml", "yeardateinpast", DataAccessMethod.Sequential)]
        public void yeardateinpast()
        {
            Step = Test.CreateNode("yeardateinpast");

            PerformbookinghotelTest();
        }
        #endregion
        #region Private Methods

        private void PerformbookinghotelTest()
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
            string firstname=TestContext.DataRow["firstname"].ToString();
            string lastname = TestContext.DataRow["address"].ToString();
            string address = TestContext.DataRow["address"].ToString();
            string cardno = TestContext.DataRow["cardno"].ToString();
            string cardtype = TestContext.DataRow["cardtype"].ToString();
            string month = TestContext.DataRow["month"].ToString() ;
            string year = TestContext.DataRow["year"].ToString();
            string cvv = TestContext.DataRow["cvv"].ToString();


            // Initialize WebDriver and perform login
            basePage.SeleniumInit();
            bookinghotel.BookingHotel(url, username, password, location, hotel, roomtype, numberOfRooms, Indates, Outdates, adult_per_room, children_per_room, firstname, lastname, address, cardno, cardtype, month, year, cvv);
            // Close WebDriver
            basePage.DriverClose();
        }

        #endregion
    }
}
