using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMActionBased.logout_Page
{
    public class LogoutPage: BaseClass
    {
        BaseClass baseClass = new BaseClass();
        public void logout()
        {
            #region Logout Page Locators
            By logoutloc = By.PartialLinkText("Click here to login");
            #endregion
            #region Logout Page elemnets
            baseClass.click(logoutloc);
            #endregion
        }
    }
}
