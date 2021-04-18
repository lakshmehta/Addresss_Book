using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
    class AddressBookMain
    {
        public static void addBook(string bookName)
        {
            if (!Program.addressBookStore.ContainsKey(bookName))
            {
                Program.addressBookStore.Add(bookName, new List<AddContact>());
            }
            AddContact person = new AddContact();
            Console.WriteLine("Enter All Details Like: ");
            Console.WriteLine("Enter First_Name: ");
            person.first_name = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            person.last_name = Console.ReadLine();
            Console.WriteLine("Enter Addree :");
            person.address = Console.ReadLine();
            Console.WriteLine("Enter City Name:");
            person.city = Console.ReadLine();
            Console.WriteLine("Enter State Name:");
            person.state = Console.ReadLine();
            Console.WriteLine("Enter pin Number:");
            person.zip = Console.ReadLine();
            Console.WriteLine("Enter Phone Number:");
            person.phone_number = Console.ReadLine();
            Console.WriteLine("Enter Email:");
            person.email = Console.ReadLine();

            List<AddContact> book = Program.addressBookStore[bookName];
            book.Add(person);
            Console.WriteLine("***************************************");
            Console.WriteLine("Your Record Added To :[" + bookName + " Book]");
            Console.WriteLine(person.ToString());


        }

    }
}
