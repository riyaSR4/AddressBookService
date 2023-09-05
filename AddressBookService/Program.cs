using AddressBookService;
using System;
using System.Collections.Generic;
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
            //operations.SizeByState();
            //operations.CountByType();
            //operations.CreateAddPerson();
            //AddressBook contact2 = new AddressBook()
            //{
            //    Id = 6,
            //    Type = "2"
            //};
            //operations.AddPersonValues(contact2);
            List<AddressBook> list = new List<AddressBook>();
            list.Add(new AddressBook()
            {
                FirstName = "Reji",
                LastName = "Skaria",
                Address = "Annikkanadu",
                City = "Pathanamthitta",
                State = "Kerala",
                Zip = 123456,
                PhoneNumber = "1023456789",
                Email = "reji@gmail.com"
            });
            list.Add(new AddressBook()
            {
                FirstName = "Jessy",
                LastName = "Reji",
                Address = "Annikkanadu",
                City = "Pathanamthitta",
                State = "Kerala",
                Zip = 123456,
                PhoneNumber = "1023456789",
                Email = "jessy@gmail.com"
            });
            list.Add(new AddressBook()
            {
                FirstName = "Rija",
                LastName = "Reji",
                Address = "Annikkanadu",
                City = "Pathanamthitta",
                State = "Kerala",
                Zip = 123456,
                PhoneNumber = "1023456789",
                Email = "rija@gmail.com"
            });
            list.Add(new AddressBook()
            {
                FirstName = "Smokey",
                LastName = "R",
                Address = "Annikkanadu",
                City = "Pathanamthitta",
                State = "Kerala",
                Zip = 123456,
                PhoneNumber = "1023456789",
                Email = "smokey@gmail.com"
            });
            list.Add(new AddressBook()
            {
                FirstName = "Toffee",
                LastName = "R",
                Address = "Annikkanadu",
                City = "Pathanamthitta",
                State = "Kerala",
                Zip = 123456,
                PhoneNumber = "1023456789",
                Email = "toffee@gmail.com"
            });
            operations.UsingWithThread(list);
            operations.UsingWithoutThread(list);
        }
    }
}