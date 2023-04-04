using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMActionBased
{
    
    public class LoginPage: BaseClass
    {
       public static BaseClass baseclass = new BaseClass();
        public void validLogin(string url, string username, string password)
        {
            #region Locators
            By userloc = By.Id("username");
            By passloc = By.Id("password");
            By loginloc = By.Id("login");
            #endregion
            #region Elements
            driver.Url = url;
            baseclass.sendText(userloc, username);
            baseclass.sendText(passloc, password);
            baseclass.click(loginloc);
            #endregion
        }
    }
}
