using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium.Edge;
using System.Diagnostics;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace SeleniumTestCommand
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
       // [Ignore]
        public void TestMethod1()
        {
             ChromeDriver driver=new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            driver.Manage().Window.Maximize();
           // String title=driver.Title;
            // if(driver.Title().eueals("TOOLSQA")){
            //     Debug.WriteLine("Title Match");
            // }
            // else
            // {
            //     Debug.WriteLine("Title Not Match");
            //     Debug.WriteLine(driver.Title());
            // }
            Thread.Sleep(2000);
            IWebElement Email = driver.FindElement(By.XPath("//input[@id='userEmail']"));
             string expectedemail = Email.GetAttribute("placeholder");
             string actualemail = "name@example.com";
             Assert.AreEqual(expectedemail,actualemail,"Email is not matched");


            IList<IWebElement> btns = driver.FindElements(By.TagName("button"));
            int expcbtns = btns.Count;
            int actualbtns = 2;
            Assert.AreEqual(expcbtns,actualbtns,"num is not matched");
            driver.Quit();
        }
          [TestMethod]
            public void TestMethod2()
        {
            ChromeDriver driver=new ChromeDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.Manage().Window.Maximize();
            IWebElement Contact= driver.FindElement(By.PartialLinkText("Contact"));
            Contact.Click();
            Thread.Sleep(2000);
            IWebElement subject =driver.FindElement(By.XPath("//select[@id='id_contact']"));
            Thread.Sleep(2000);
            // ((IJavaScriptExecutor)driver) .ExecuteScript("arguments[0].scrollIntoView(true);", subject);
            // SelectElement dropDown = new SelectElement(subject);
            //  dropDown.SelectByText("Customer service");
            SelectElement st = new SelectElement(driver.FindElement(By.Id("id_contact")));
            st.SelectByText("Customer service");
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
    }

