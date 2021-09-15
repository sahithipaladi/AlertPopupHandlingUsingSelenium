﻿/*
 * Project: Popup Handling using alert methods using selenium
 * Author:  p.sahithi
 * Date :   14/09/2021
 */
using NUnit.Framework;

namespace AlertPopUpMessages
{

    public class Tests : Base.Baseclass
    {

        [Test, Order(1)]
        public void test_alert()
        {
            DoAction.DoActions.TestAcceptAlert();
        }

        [Test, Order(2)]
        public void test_confirm()
        {
            DoAction.DoActions.TestConfirmAlert();
        }

        [Test, Order(3)]
        public void test_dismiss()
        {
            DoAction.DoActions.TestDismissAlert();
        }

        [Test, Order(4)]
        public void test_sendalert_text()
        {
            DoAction.DoActions.TestSendAlertText();
        }
    }
}