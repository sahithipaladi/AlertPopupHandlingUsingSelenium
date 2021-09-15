﻿/*
 * Project: Popup Handling using alert methods using selenium
 * Author:  p.sahithi
 * Date :   14/09/2021
 */
using AlertPopUpMessages.AlertElements;
using AlertPopUpMessages.ConfirmMethod;
using AlertPopUpMessages.DismissMethod;
using AlertPopUpMessages.PromptMethod;
using  OpenQA.Selenium;
using System;
namespace AlertPopUpMessages.DoAction
{
    public class DoActions : Base.Baseclass
    {
        public static void TestAcceptAlert()
        {
            //find the button element by using Css Selector
            AlertClass alert = new AlertClass(driver);
            alert.alertBtn.Click();
            System.Threading.Thread.Sleep(2000);

            //send the commands to alert window
            var alert_win = driver.SwitchTo().Alert();
            //Accept the alert
            alert_win.Accept();

            System.Threading.Thread.Sleep(2000);

            Console.WriteLine(alert.clickResult.Text);
            System.Threading.Thread.Sleep(2000);

            if (alert.clickResult.Text == "You successfuly clicked an alert")
            {
                Console.WriteLine("Alert Test Successful");
            }
        }

        public static void TestConfirmAlert()
        {
            ConfirmClass confirm = new ConfirmClass(driver);
            confirm.confirmBtn.Click();
            System.Threading.Thread.Sleep(2000);

            //send the commands to alert window
            var confirm_win = driver.SwitchTo().Alert();
            //Accept the alert
            confirm_win.Accept();
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine(confirm.clickResult.Text);
            System.Threading.Thread.Sleep(2000);

            if (confirm.clickResult.Text == "You clicked: Ok")
            {
                Console.WriteLine("Confirm Test Successful");
            }
        }

        public static void TestDismissAlert()
        {
            DismissClass dismiss = new DismissClass(driver);
            dismiss.dismissBtn.Click();
            System.Threading.Thread.Sleep(2000);

            //send the commands to alert window
            var confirm_win = driver.SwitchTo().Alert();
            //Dismiss the alert
            confirm_win.Dismiss();
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine(dismiss.clickResult.Text);
            System.Threading.Thread.Sleep(2000);

            if (dismiss.clickResult.Text == "You clicked: Cancel")
            {
                Console.WriteLine("Dismiss Test Successful");
            }
        }
        public static void TestSendAlertText()
        {
            Promptclass prompt = new Promptclass(driver);
            prompt.promptBtn.Click();
            System.Threading.Thread.Sleep(2000);

            //send the commands to alert window
            var alert_win = driver.SwitchTo().Alert();
            alert_win.SendKeys("This is a test alert message");
            //Accept the alert
            alert_win.Accept();
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine(prompt.clickResult.Text);
            System.Threading.Thread.Sleep(2000);

            if (prompt.clickResult.Text == "You entered: This is a test alert message")
            {
                Console.WriteLine("Send Text Alert Test Successful");
            }
        }
    }
}
