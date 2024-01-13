// See https://aka.ms/new-console-template for more information
using zavd_4_c_;

namespace Myspace;

class Program
{
    static void Main(string[] args)
    {
        Author author = new Author("John Doe");
        Book book = new Book("Sample Book", author, 25.99);

        Book decoratedBook = new ReviewDecorator(new CoverDecorator(book, "Hardcover"), "Great book!");

        LibraryUser user = new LibraryUser("Alice");

        int choice;
        do
        {
            Console.WriteLine("Library Management System");
            Console.WriteLine("1. Display Book Information");
            Console.WriteLine("2. Borrow Book");
            Console.WriteLine("3. Return Book");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        decoratedBook.Display();
                        break;
                    case 2:
                        user.BorrowBook(decoratedBook);
                        break;
                    case 3:
                        user.ReturnBook(decoratedBook);
                        break;
                    case 0:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

        } while (choice != 0);
    }
}