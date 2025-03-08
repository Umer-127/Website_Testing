using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V130.FileSystem;
using OpenQA.Selenium.DevTools.V131.FileSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;


namespace Final_project_Website_Testing_
{
    public class BasePage

    {
       


        public static IWebDriver driver;
        public static ExtentReports extentReports;
        public static ExtentTest Test;
        public static ExtentTest Step;

        public void SeleniumInit()
        {
            var myDriver = new ChromeDriver();
            driver = myDriver;
        }
        public void DriverClose()
        {
            Thread.Sleep(2000);
            driver.Close();
        }
        public static void CreateReport(string path)
        {
            extentReports = new ExtentReports();    
            var sparkReporter=new ExtentSparkReporter(path);
            extentReports.AttachReporter(sparkReporter);
        }
        public static void TakeScreenShots(Status status,string stepDetail)
        {
            string path = @"C:\ExtentReports\images" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            System.IO.File.WriteAllBytes(path,screenshot.AsByteArray);
            Step.Log(status, stepDetail, MediaEntityBuilder.CreateScreenCaptureFromPath(path).Build());



        }
    }
}
