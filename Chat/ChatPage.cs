using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    class ChatPage
    {
        public IWebDriver WebDriver { get; }
        public ChatPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        #region Get_Element

        //change theme
        public IWebElement btntheme => WebDriver.FindElement(By.ClassName("theme-chooser-wrapper dropdown-wrapper"));
        public IWebElement changetab => WebDriver.FindElement(By.XPath("//div[@class='type-chooser']/child::div[2]"));
        public IWebElement selecttheme => WebDriver.FindElement(By.XPath("//div[@class='theme-chooser-dropdown dropdown active']/child::ul/child::li[4]/child::span[1]"));

        //input information
        public IWebElement inputinformation => WebDriver.FindElement(By.XPath("//div[@class='demo-section k-content']/child::div/child::span/child::input"));
        public IWebElement btnsend => WebDriver.FindElement(By.XPath("//div[@class='demo-section k-content']/child::div/child::span/child::span/child::button"));
        public IWebElement Info1 => WebDriver.FindElement(By.XPath("//div[@class='k-message-list-content']/child::div[1]/child::div[1]/child::div"));
        public IWebElement Info2 => WebDriver.FindElement(By.XPath("//div[@class='k-message-list-content']/child::div[1]/child::div[2]/child::div"));
        public IWebElement btnbook => WebDriver.FindElement(By.XPath("//div[@class='k-message-list-content']/child::div[3]/child::span"));
        public IWebElement selectspecialist => WebDriver.FindElement(By.XPath("//div[@class='k-message-list-content']/child::div[4]/child::div/child::div[2]/child::span[4]"));


        #endregion

        #region Change_Theme

        public void Change_Theme()
        {
            btntheme.Click();
            System.Threading.Thread.Sleep(500);
            changetab.Click();
            System.Threading.Thread.Sleep(500);
            selecttheme.Click();
            System.Threading.Thread.Sleep(2000);
        }

        #endregion

        #region Input_Information

        public void Input_Information()
        {
            inputinformation.SendKeys("Hi");
            System.Threading.Thread.Sleep(500);
            btnsend.Click();
            System.Threading.Thread.Sleep(500);
            inputinformation.SendKeys("How are you?");
            System.Threading.Thread.Sleep(500);
            btnsend.Click();
            System.Threading.Thread.Sleep(500);

            if (Info1.Text == "Hi" && Info2.Text == "How are you?")
            {
                Console.WriteLine("The entered information was displayed successfully");
            }
            else
            {
                Console.WriteLine("The entered information was not displayed");
                Assert.Fail("The entered information was not displayed");
            }

            System.Threading.Thread.Sleep(40000);

            btnbook.Click();
            System.Threading.Thread.Sleep(4000);

            selectspecialist.Click();
            System.Threading.Thread.Sleep(500);
        }

        #endregion

    }
}
