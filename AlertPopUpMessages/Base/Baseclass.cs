/*
 * Project: Popup Handling using alert methods using selenium
 * Author:  p.sahithi
 * Date :   14/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AlertPopUpMessages.Base
{

    public class Baseclass
    {
        public static IWebDriver driver;
        [SetUp]
        public void Setup()
        {

            driver = new ChromeDriver();
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            driver.Url = "http://the-internet.herokuapp.com/javascript_alerts";
        }

        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }
    }
}
