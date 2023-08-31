using AddressBookService;
using System;
using System.Net;

namespace AddressBookService
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddressBook contact = new AddressBook()
            //{
            //    FirstName = "Riya S",
            //    LastName = "Reji",
            //    Address = "Mylapra",
            //    City = "Pathanamthitta",
            //    State = "Kerala",
            //    Zip = 123456,
            //    PhoneNumber = "1234567890",
            //    Email = "riya@gmail.com"
            //};
            Operations operations = new Operations();
            //operations.AddContact(contact);
            //AddressBook contact1 = new AddressBook()
            //{
            //    FirstName = "Riya",
            //    LastName = "Reji",
            //    Address = "Mylapra",
            //    City = "Pathanamthitta",
            //    State = "Kerala",
            //    Zip = 123456,
            //    PhoneNumber = "1234567890",
            //    Email = "riya@gmail.com"
            //};
            //operations.UpdateContact(contact1);
            //operations.DeleteContact("riya");
            //operations.City("Pathanamthitta");
            //operations.State("Kerala");
            //operations.SizeByCity();
            operations.SizeByState();
        }
    }
}