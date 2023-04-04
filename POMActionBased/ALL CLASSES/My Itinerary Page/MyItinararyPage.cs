using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMActionBased.My_Itinerary_Page
{
    public class MyItinararyPage: BaseClass
    {
        BaseClass baseclass = new BaseClass();
        public void myitinararypage()
        {
        #region My Itinarary Page Locators
        By logout = By.Id("logout");
        #endregion
        #region My Itinarary Page Elements

            baseclass.click(logout);
           
        }
        #endregion
    }
}
