using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(); //Creating an object of the class Book, Book is now a data type in c#

            //Creation of first book
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 130;
            book1.actUsers = 45;

            Book book2 = new Book();
            //Creation of second book
            book2.title = "Lord of the rings";
            book2.author = "Tolkein";
            book2.pages = 999;



            //Members creation
            Members mem1 = new Members();

            mem1.name = "Abednigo";
            mem1.age = 45;
            mem1.address = "14332 Makongo street";
            mem1.phoneNumber = "1234567890";



            Console.WriteLine("The book Title " + book1.title + "  Author: " + book1.author + "  Pages: " + book1.pages + "  Current active users: " + book1.actUsers);
            Console.WriteLine("We have a new member");
            Console.WriteLine("\n" + mem1.name + "\n " + mem1.age + "\n " + mem1.address + "\n " + mem1.phoneNumber);
            //Freeze consol
            Console.Read();

        }
    }
}