using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V129.Debugger;
using OpenQA.Selenium.Support.UI;
using System;

namespace Final_project_Website_Testing_
{
    public class LoginPage : BasePage
    {
        // BasePage object initialization
        BasePage basepage = new BasePage();

        #region Locators
        public static By usernameTXT = By.Id("username");
        public static By passwordTXT = By.Id("password");
        public static By loginbtn = By.Id("login");
        public static By logout = By.LinkText("Logout");
        public static By bookeditinerary = By.LinkText("Booked Itinerary");
        public static By checkboxItem = By.Name("ids[]");
        public static By cancelButton = By.Name("cancelall");
        public static By Currentpassword = By.Id("current_pass");
        public static By Newpassword = By.Id("new_password");
        public static By Confirmpassword = By.Id("re_password");
        public static By submitbtn = By.Id("Submit");
        public static By Changepassword = By.LinkText("Change Password");
        #endregion

        #region Methods

        public void Login(string url, string username, string password)
        {
            

                driver.Url = url;

                // Enter username and take a screenshot
                driver.FindElement(usernameTXT).SendKeys(username);
                BasePage.TakeScreenShots(Status.Pass, "Entered username");

                // Enter password and take a screenshot
                driver.FindElement(passwordTXT).SendKeys(password);
                BasePage.TakeScreenShots(Status.Pass, "Entered password");

                // Click the login button and take a screenshot
                driver.FindElement(loginbtn).Click();
                BasePage.TakeScreenShots(Status.Pass, "Clicked login button");

               
        }
       


        public void LoginOut(string url, string username, string password)
        {
            Login(url, username, password);
            driver.FindElement(logout).Click();
            BasePage.TakeScreenShots(Status.Pass, "Clicked logout button");

        }


        public void BookedItinerary(string url, string username, string password)
        {
            Login(url, username, password);
            driver.FindElement(bookeditinerary).Click();
            BasePage.TakeScreenShots(Status.Pass, "Clicked Book itinerary");

        }


        public void CancelItem(string url, string username, string password)
        {
            // Login and navigate to the itinerary
            Login(url, username, password);
            driver.FindElement(bookeditinerary).Click();

            // Select the item to cancel and confirm the alert
            driver.FindElement(checkboxItem).Click();
            BasePage.TakeScreenShots(Status.Pass, "Clicked checkbox button");

            driver.FindElement(cancelButton).Click();
            BasePage.TakeScreenShots(Status.Pass, "Clicked cancel button");


            // Handle the confirmation popup
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept(); // Click "OK" on the alert
            

        }
        public void changepass(string url, string username, string password,string currentpassword,string newpassword,string confirmpassword)
        {
            Login(url, username, password);
            driver.FindElement(Changepassword).Click();
            driver.FindElement(Currentpassword).SendKeys(currentpassword);
            driver.FindElement(Newpassword).SendKeys(newpassword);
            driver.FindElement(Confirmpassword).SendKeys(confirmpassword);
            driver.FindElement(submitbtn).Click();

        }


        #endregion
    }
}
