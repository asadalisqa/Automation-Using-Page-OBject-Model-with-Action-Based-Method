using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using POMActionBased.Book_a_Hotel_Page;
using POMActionBased.Confirm_booking;
using POMActionBased.logout_Page;
using POMActionBased.My_Itinerary_Page;
using POMActionBased.Select_Hotel_Page;
using System;

namespace POMActionBased
{
    [TestClass]
    public class Execution
    {
        #region Objects of all classes
        BaseClass baseClass = new BaseClass();
        LoginPage loginpage = new LoginPage();
        SearchPage searchpage = new SearchPage();
        SelectHotel selecthotels = new SelectHotel();
        BookHotel bookhotel = new BookHotel();
        ConfirmBooking confirmBooking = new ConfirmBooking();
        MyItinararyPage myitinery = new MyItinararyPage();
        LogoutPage logoutpage = new LogoutPage();
        #endregion

        [TestInitialize]
        public void Init() 
        {
            baseClass.drivierinit();
        }
        //[TestCleanup]
        public void closedriver()
        {
            baseClass.driverclose();
        }
        [TestMethod]
        public void TestMethod1()
        {
            //Login Page details
            loginpage.validLogin("https://adactinhotelapp.com/", "AmirImam", "AmirImam");
            
            //Search Hotel Page details
            searchpage.search("Sydney", "Hotel Sunshine", "Standard", "2 - Two","22/03/2002","29/03/2002", "2 - Two", "2 - Two");

            //Select Hotel Page detail
            selecthotels.selecthotel();

            //Book Hotel Page details
            bookhotel.bookhotel("Asad", "Ali", "Karachi Pakistan", "97908765908767980", "VISA", "February", "2022", "1234");

            //Go To Booked Itinerary
            confirmBooking.my_itinerary();

            //Go to logout page
            myitinery.myitinararypage();

            //go to login page again
            logoutpage.logout();




        }
    }
}
