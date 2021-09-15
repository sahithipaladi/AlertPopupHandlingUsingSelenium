/*
 * Project: Popup Handling using alert methods using selenium
 * Author:  p.sahithi
 * Date :   14/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AlertPopUpMessages.PromptMethod
{
    public class Promptclass
    {
        public Promptclass(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "button[onclick='jsPrompt()']")]
        [CacheLookup]
        public IWebElement promptBtn;

        [FindsBy(How = How.Id, Using = "result")]
        [CacheLookup]
        public IWebElement clickResult;
    }
}