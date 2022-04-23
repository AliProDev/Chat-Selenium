using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Chat
{
    [Binding]
    [Scope(Tag = "Chat")]
    public sealed class ChatStep
    {

        IWebDriver webDriver;
        ChatPage chat;

        #region Launch_Application

        [Given(@"launch application")]
        public void Launch_Application()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://demos.telerik.com/kendo-ui/chat/healthcare");
            chat = new ChatPage(webDriver);
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Cookies.DeleteAllCookies();
            System.Threading.Thread.Sleep(2000);
        }

        #endregion

        #region Change_Theme

        [When(@"change theme chat")]
        public void Change_Theme()
        {
            System.Threading.Thread.Sleep(2000);
            chat.Change_Theme();
        }

        #endregion

        #region Input_Information

        [Then(@"click Book a Check-up button in chat and Choose a specialist")]
        public void Input_Information()
        {
            System.Threading.Thread.Sleep(2000);
            chat.Input_Information();
        }

        #endregion

    }
}
