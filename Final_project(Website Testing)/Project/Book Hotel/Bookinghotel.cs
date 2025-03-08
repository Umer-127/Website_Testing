using OpenQA.Selenium;
using System;
using AventStack.ExtentReports;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project_Website_Testing_
{
    public  class Bookinghotel:BasePage
    {
        #region Locators
        public static By firstnameTXT = By.Id("first_name");

        public static By Lastname = By.Id("last_name");
        public static By Address = By.Id("address");
        public static By CardNo = By.Id("cc_num");
        public static By Cardtype = By.Id("cc_type");
        public static By Month = By.Id("cc_exp_month");
        public static By Year = By.Id("cc_exp_year");
        public static By Cvvnumber = By.Id("cc_cvv");
        public static By Booknow = By.Id("book_now");


        #endregion
        #region Method
        public void BookingHotel(string url, string username, string password, string location, string hotel, string room_type, string room_nos, string datepick_ins, string datepick_outs, string adult_room, string child_room, string firstname, string lastname, string address, string cc_num, string cc_type, string cc_exp_month, string cc_exp_Year, string cc_ccv)

        {
            
            var searchinghotel = new SearchHotel();
            searchinghotel.Searchhotel(url, username, password,location,hotel,room_type,room_nos,datepick_ins,datepick_outs,adult_room,child_room);
            driver.FindElement(firstnameTXT).SendKeys(firstname);
            BasePage.TakeScreenShots(Status.Pass, "Entered firstname");

            driver.FindElement(Lastname).SendKeys(lastname);
            BasePage.TakeScreenShots(Status.Pass, "Entered lastname");

            driver.FindElement(Address).SendKeys(address);
            BasePage.TakeScreenShots(Status.Pass, "Entered address");

            driver.FindElement(CardNo).SendKeys(cc_num);
            BasePage.TakeScreenShots(Status.Pass, "Entered cardno");

            driver.FindElement(Cardtype).SendKeys(cc_type);
            BasePage.TakeScreenShots(Status.Pass, "Entered cardtype");

            driver.FindElement(Month).SendKeys(cc_exp_month);
            BasePage.TakeScreenShots(Status.Pass, "Entered Expire Month");

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].value = arguments[1];", driver.FindElement(Year), cc_exp_Year);
            js.ExecuteScript("arguments[0].dispatchEvent(new Event('change'));", driver.FindElement(Year));
            BasePage.TakeScreenShots(Status.Pass, "Entered Expire Year");

            driver.FindElement(Cvvnumber).SendKeys(cc_ccv);
            BasePage.TakeScreenShots(Status.Pass, "Entered CvvNumber");

            driver.FindElement(Booknow).Click();
            BasePage.TakeScreenShots(Status.Pass, "Entered Booknow");



        }
        #endregion
    }

}
