using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMActionBased.Select_Hotel_Page
{
    public class SelectHotel : BaseClass
    {
         BaseClass baseclass = new BaseClass();
        public void selecthotel()
        {
            #region Select hotel locators
            By radiobutton = By.Id("radiobutton_0");
            By continuebutton = By.Id("continue");
            #endregion
            #region Select Hotel Elements
            baseclass.click(radiobutton);
            baseclass.click(continuebutton);
            #endregion
        }

    }
}
