using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMActionBased.Confirm_booking
{
    public class ConfirmBooking: BaseClass
    {
        BaseClass baseclass = new BaseClass();
        #region Confirm Booking Page locators
        By MylitButton = By.Id("my_itinerary");
        #endregion
        #region Confirm Booking Page Elements
        public void my_itinerary()
        {
            baseclass.click(MylitButton);
        }
        #endregion
    }
}
