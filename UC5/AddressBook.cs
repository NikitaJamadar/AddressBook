using System;
using System.Collections.Generic;
using System.Text;

namespace UC5
{
    class AddressBook
    {
        public static List<ContactDetail> Details = new List<ContactDetail>();

        public static void EnterDetails()
        {
            Console.WriteLine("How many contacts you want to add in address book");
            int noOfContacts = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < noOfContacts; i++)
            {
                ContactDetail contact = new ContactDetail();

                Console.WriteLine("Enter your First Name");
                contact.FirstName = Console.ReadLine();

                Console.WriteLine("Enter your Last Name");
                contact.LastName = Console.ReadLine();

                Console.WriteLine("Enter your Address");
                contact.Address = Console.ReadLine();

                Console.WriteLine("Enter your City");
                contact.City = Console.ReadLine();

                Console.WriteLine("Enter your state");
                contact.State = Console.ReadLine();

                Console.WriteLine("Enter your ZipCode");
                contact.ZipCode = Console.ReadLine();

                Console.WriteLine("Enter your Phone Number");
                contact.PhoneNumber = Console.ReadLine();

                Console.WriteLine("Enter your Email ID");
                contact.EmailId = Console.ReadLine();

                Details.Add(contact);
                Console.WriteLine("----------------------------------------------");
                ViewDetails();
                Console.WriteLine($"{contact.FirstName} contact Added Succesfully");
            }
        }

        public static void ViewDetails()
        {
            foreach (var items in Details)
            {
                Console.WriteLine("First Name:" + items.FirstName);
                Console.WriteLine("Last Name:" + items.LastName);
                Console.WriteLine("Address:" + items.Address);
                Console.WriteLine("city:" + items.City);
                Console.WriteLine("State:" + items.State);
                Console.WriteLine("Zip Code:" + items.ZipCode);
                Console.WriteLine("Phone Number:" + items.PhoneNumber);
                Console.WriteLine("Email ID:" + items.EmailId);
            }
        }
    }
}
