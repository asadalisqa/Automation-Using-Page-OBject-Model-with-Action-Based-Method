using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMActionBased.Book_a_Hotel_Page
{
    public class BookHotel: BaseClass
    {
        BaseClass baseclass = new BaseClass();
        public void bookhotel(string firstname, string lastname, string address, string cardnumber, string cardtype, string expmonth,string expyear, string cvvnumber)
        {
            #region Book hotel Page locators
            By fnameloc = By.Id("first_name");
            By lnameloc = By.Id("last_name");
            By addressloc = By.Id("address");
            By cardnumloc = By.Id("cc_num");
            By cardtypeloc = By.Id("cc_type");
            By xmonthloc = By.Id("cc_exp_month");
            By xyearloc = By.Id("cc_exp_year");
            By cvvnumloc = By.Id("cc_cvv");
            By BookNowButton = By.Id("book_now");
            #endregion
            #region Book hotel Page Elements
            baseclass.sendText(fnameloc, firstname);
            baseclass.sendText(lnameloc, lastname);
            baseclass.sendText(addressloc, address);
            baseclass.sendText(addressloc, address);
            baseclass.sendText(cardnumloc, cardnumber);
            baseclass.dropdowns(cardtypeloc, cardtype);
            baseclass.dropdowns(xmonthloc, expmonth);
            baseclass.dropdowns(xyearloc, expyear);
            baseclass.sendText(cvvnumloc, cvvnumber);
            baseclass.click(BookNowButton);
            Wait(8000);
            #endregion
        }
    }
}
