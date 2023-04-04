using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMActionBased
{
    internal class SearchPage: BaseClass
    {
        BaseClass baseclass = new BaseClass();
        public void search(string location, string hotels, string roomtype,string nofrooms, string indate, string outdate, string adprroom, string chprroom)
        {
            #region Search Page Locators
            By locationloc = By.Id("location");
            By hotelloc = By.Id("hotels");
            By rtypeloc = By.Id("room_type");
            By nofroomloc = By.Id("room_nos");
            By indateloc = By.Id("datepick_in");
            By outdateloc = By.Id("datepick_out");
            By adprroomloc = By.Id("adult_room");
            By chprroomloc = By.Id("child_room");
            By searchbutton = By.Id("Submit");

            #endregion
            #region Search Page elements
            baseclass.dropdowns(locationloc,location);
            baseclass.dropdowns(hotelloc, hotels);
            baseclass.dropdowns(rtypeloc, roomtype);
            baseclass.dropdowns(nofroomloc, nofrooms);
            baseclass.sendText(indateloc, indate);
            baseclass.sendText(outdateloc, outdate);
            baseclass.dropdowns(adprroomloc, adprroom);
            baseclass.dropdowns(chprroomloc, chprroom);
            baseclass.click(searchbutton);
            #endregion

        }
    }
}
