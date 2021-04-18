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

            int choice = 0;
            while (choice != 6)
            {
                Console.WriteLine("1.Add Contacts");
                Console.WriteLine("2.Edit Existing Contact");
                Console.WriteLine("3.Delete Person Details");
                Console.WriteLine("4.Search persons using city or state");
                Console.WriteLine("5.Search Number of persons in city or state");
                Console.WriteLine("6.close");
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
                        Console.WriteLine("Enter city or state to find a person");
                        string cityOrState = Console.ReadLine();
                        AddressBookMain.searchPersonUsingCityOrStateInMultipleBooks(cityOrState);
                        break;
                    case 5:
                        Console.WriteLine("Enter city or state to get total number of persons");
                        string cityOrState1 = Console.ReadLine();
                        int numberOfPerson = AddressBookMain.searchNumberOfPersonUsingCityOrStateInMultipleBooks(cityOrState1);
                        Console.WriteLine("Total number of persons are :" + numberOfPerson);
                        break;
                    case 6:
                        choice = 6;
                        break;
                   
                    default:
                        Console.WriteLine("Invalid choice !");
                        break;
                }




            }
        }
    }
}