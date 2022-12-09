using AddressBooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Addressbook
    {
        List<Contact> data = new List<Contact>();
        public void CreateContact()
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter Firstname");
            contact.Firstname = Console.ReadLine();
            Console.WriteLine("Enter Lastname");
            contact.Lastname = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            contact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter PhoneNumber");
            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email");
            contact.Email = Console.ReadLine();
            data.Add(contact);
        }
        public void DisplayContact()
        {
            foreach (Contact records in data)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*******Contact*******");
                Console.WriteLine("Firstname" + records.Firstname);
                Console.WriteLine("Lastname" + records.Lastname);
                Console.WriteLine("Address" + records.Address);
                Console.WriteLine("City" + records.City);
                Console.WriteLine("State" + records.State);
                Console.WriteLine("Zip" + records.Zip);
                Console.WriteLine("PhoneNumber" + records.PhoneNumber);
                Console.WriteLine("Email" + records.Email);
            }
        }
    }
}