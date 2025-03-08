using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project_Website_Testing_
{
    public class SearchHotel:BasePage
    {
        BasePage basepage = new BasePage();
        
        
        #region Locators
       
        public static By locationDropdown = By.Id("location");
        public static By hotelsDropdown = By.Id("hotels");
        public static By roomTypeDropdown = By.Id("room_type");
        public static By numberOfRoomsDropdown = By.Id("room_nos");
        public static By checkInDateInput = By.CssSelector("#datepick_in");
        public static By checkOutDateInput = By.CssSelector("#datepick_out");
        public static By adultsPerRoomDropdown = By.Id("adult_room");
        public static By childrenPerRoomDropdown = By.Id("child_room");
        public static By searchButton = By.Id("Submit");
        public static By resetButton = By.Id("Reset");
       
        public static By continuebutton = By.Id("continue");

        #endregion
        
        #region Method
        public void Searchhotel(string url,string username,string password,string location,string hotel,string room_type,string room_nos,string datepick_ins, string datepick_outs, string adult_room, string child_room)
        {
            var loginPage = new LoginPage();
            loginPage.Login(url, username, password);
            driver.FindElement(locationDropdown).SendKeys(location);
            BasePage.TakeScreenShots(Status.Pass, "Entered location");

            driver.FindElement(hotelsDropdown).SendKeys(hotel);
            BasePage.TakeScreenShots(Status.Pass, "Entered hotel");

            driver.FindElement(roomTypeDropdown).SendKeys(room_type);
            BasePage.TakeScreenShots(Status.Pass, "Entered RoomType");

            driver.FindElement(numberOfRoomsDropdown).SendKeys(room_nos);
            BasePage.TakeScreenShots(Status.Pass, "Entered numbers of rooms");



            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].value = arguments[1];", driver.FindElement(checkInDateInput), datepick_ins);
            js.ExecuteScript("arguments[0].dispatchEvent(new Event('change'));", driver.FindElement(checkInDateInput));
            BasePage.TakeScreenShots(Status.Pass, "Entered Date In");

            js.ExecuteScript("arguments[0].value = arguments[1];", driver.FindElement(checkOutDateInput), datepick_outs);
            js.ExecuteScript("arguments[0].dispatchEvent(new Event('change'));", driver.FindElement(checkOutDateInput));
            BasePage.TakeScreenShots(Status.Pass, "Entered DateOut");


            driver.FindElement(adultsPerRoomDropdown).SendKeys(adult_room);
            BasePage.TakeScreenShots(Status.Pass, "Entered Adult");

            driver.FindElement(childrenPerRoomDropdown).SendKeys(child_room);
            BasePage.TakeScreenShots(Status.Pass, "Entered Children");

            driver.FindElement(searchButton).Click();
            BasePage.TakeScreenShots(Status.Pass, "Search the hotel");

            driver.FindElement(By.CssSelector("#radiobutton_0")).Click();
            BasePage.TakeScreenShots(Status.Pass, "select the hotel");

            driver.FindElement(continuebutton).Click();
            BasePage.TakeScreenShots(Status.Pass, "Continue Hotel");

        }
        #endregion
    }
}
