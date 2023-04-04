using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POMActionBased
{
    public class BaseClass
    {
        public static IWebDriver driver;
        public  void drivierinit()
        {
            driver = new ChromeDriver();
        }
        public void driverclose()
        {
            driver.Quit();
        }
        public void sendText(By by, string value)
        {
            driver.FindElement(by).SendKeys(value);  
        }
        public void click(By by)
        {
            driver.FindElement(by).Click();
        }
        public void clear(By by)
        {
            driver.FindElement(by).Clear();
        }
        public void url(string myurl)
        {
            driver.Manage().Window.Maximize();
            driver.Url = myurl;
        }
        public void dropdowns(By by, string text)
        {
            
            var dropselect = driver.FindElement(by);
            var selectelement = new SelectElement(dropselect);
            selectelement.SelectByText(text);
        }
        public void Wait(int time_in_ms)
        {
            Thread.Sleep(time_in_ms);
        }
    }
}
