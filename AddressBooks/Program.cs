﻿using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addressbook book = new Addressbook();
            book.CreateContact();
            while (true)
            {
                Console.WriteLine("1. Create Contact\n2. Display Contact\n3. Edit Contact");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        book.CreateContact();
                        break;
                    case 2:
                        book.DisplayContact();
                        break;
                    case 3:
                        book.EditContact();
                        break;
                }
            }
        }
    }
}