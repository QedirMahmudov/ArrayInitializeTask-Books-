using ArrayInitializeTask_Books_.Models;

namespace ArrayInitializeTask_Books_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookLibrary library = new BookLibrary();

            Book book = new Book("Kitab", "Deneme");
            Console.WriteLine("---------------------------------------");
            Book book2 = new Book("Kitab2", "Deneme");
            Console.WriteLine("---------------------------------------");
            Book book3 = new Book("Kitab3", "Denemememememe");

            library.Add(book);
            library.Add(book2);
            library.Add(book3);
            Console.Clear();

            //Console.WriteLine(book.IsAvailable);
            //library.BorrowBook("Kitab");
            //Console.WriteLine(book.IsAvailable);
            //library.ReturnBook("Kitab");
            //Console.WriteLine(book.IsAvailable);


            library.SearchByAuthor("Deneme");


            //library.ShowAll();
            //library.Remove("kitab");
            //library.ShowAll();



            //Console.Clear();

            //book.Author = "den.e";
            //book.GetInfo();
        }
    }
}
