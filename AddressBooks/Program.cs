using AddressBooks;
using System;

namespace AddressBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook book = new AddressBook();
            book.CreateContact();
        }
    }
}