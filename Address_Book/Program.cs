using System;
using System.Collections.Generic;

namespace Address_Book
{
    class Program
    {
        public static Dictionary<string, List<AddContact>> addressBookStore = new Dictionary<string, List<AddContact>>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to the Address Book");


            Console.WriteLine("Enter the book name you want to store");
            string bookName = Console.ReadLine();
            AddressBookMain.addBook(bookName);
        }
    }
}
