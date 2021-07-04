using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddressBook addressBook  = new AddressBook();
            AddressDetails address = new AddressDetails();
            address.FirstName = "A";
            address.LastName = "b";
            address.PhoneNumber = "566777";
            address.State = "h";
            address.City = "b";
            address.ZipCode = "456";
            address.Address = "h";
            address.Email = "gh";

            address.GetData();
            addressBook.AddNewRecord(address);
            addressBook.UpdateRecord(address);
            
           
        }
    }
}
