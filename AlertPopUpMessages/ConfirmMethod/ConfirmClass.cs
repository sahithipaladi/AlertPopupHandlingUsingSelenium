/*
 * Project: Popup Handling using alert methods using selenium
 * Author:  p.sahithi
 * Date :   14/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AlertPopUpMessages.ConfirmMethod
{
    public class ConfirmClass
    {
        public ConfirmClass(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "button[onclick='jsConfirm()']")]
        [CacheLookup]
        public IWebElement confirmBtn;

        [FindsBy(How = How.Id, Using = "result")]
        [CacheLookup]
        public IWebElement clickResult;
    }
}

