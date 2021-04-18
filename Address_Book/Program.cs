﻿using System;
using System.Collections.Generic;

namespace Address_Book
{
    class Program
    {
        public static Dictionary<string, List<AddContact>> addressBookStore = new Dictionary<string, List<AddContact>>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to the Address Book");

            int choice = 0;
            while (choice != 4)
            {
                Console.WriteLine("1.Add Contacts");
                Console.WriteLine("2.Edit Existing Contact");
                Console.WriteLine("3.Delete Person Details");
                Console.WriteLine("4.close");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter name of the address book in which you want to add record.");
                        String bookName = Console.ReadLine();
                        AddressBookMain.addBook(bookName);
                        break;
                    case 2:
                        Console.WriteLine("Enter the book name in which you want to Edit data:");
                        string bookNameHasReocrd = Console.ReadLine();
                        Console.WriteLine("Enter Person's FirstName to edit data:");
                        string recordNameToEdit = Console.ReadLine();
                        AddressBookMain.edit(bookNameHasReocrd, recordNameToEdit);
                        break;
                    case 3:
                        Console.WriteLine("Enter name of the address book you want to delete record in.");
                        String bookName1 = Console.ReadLine();
                        AddressBookMain.delete(bookName1);
                        break;
                    case 4:
                        choice = 4;
                        break;
                    default:
                        Console.WriteLine("Invalid choice !");
                        break;
                }




            }
        }
    }
}