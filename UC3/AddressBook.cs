using System;
using System.Collections.Generic;
using System.Text;

namespace UC3
{
    class AddressBook
    {
        public static List<ContactDetail> Details = new List<ContactDetail>();

        public static void EnterDetails()
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

        public static void EditDetails()
        {
            Console.WriteLine("Enter name of Contact you want to edit");
            string editDetails = Console.ReadLine();

            foreach(var contacts in Details)
            {
                if (editDetails.ToLower() == contacts.FirstName.ToLower())
                {
                    Console.WriteLine("\nChoice what you want to edit\n 1.First name\n2.Last name\n3.Address" +
                            "\n4.City\n5.State\n6.Zip Code\n7.Phone Number\n8.Email");

                    int editChoice = int.Parse(Console.ReadLine());
                    switch (editChoice)
                    {
                        case 1:
                            Console.WriteLine("enter new First name");
                            contacts.FirstName = Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine("enter new last name");
                            contacts.LastName = Console.ReadLine();
                            break;

                        case 3:
                            Console.WriteLine("enter new Address");
                            contacts.Address = Console.ReadLine();
                            break;

                        case 4:
                            Console.WriteLine("enter new city");
                            contacts.City = Console.ReadLine();
                            break;

                        case 5:
                            Console.WriteLine("enter new State");
                            contacts.State = Console.ReadLine();
                            break;

                        case 6:
                            Console.WriteLine("enter new zipcode");
                            contacts.ZipCode = Console.ReadLine();
                            break;

                        case 7:
                            Console.WriteLine("enter new Phone Number");
                            contacts.PhoneNumber = Console.ReadLine();
                            break;

                        case 8:
                            Console.WriteLine("enter new EmailID");
                            contacts.EmailId = Console.ReadLine();
                            break;

                    }
                   
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist in Address Book",editDetails);
                }
            }
        }
    }
}
