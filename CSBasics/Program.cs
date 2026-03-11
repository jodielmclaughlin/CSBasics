using System.Net.NetworkInformation;

namespace CSBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book("The Hobbit", 310);

            
            Console.WriteLine("Title: " + myBook.Title);
            Console.WriteLine("Pages: " + myBook.Pages);
            Console.WriteLine("Current Page: " + myBook.CurrentPage);
            myBook.TurnPage();
            Console.WriteLine("Current Page: " + myBook.CurrentPage);

        }
      
    }
}
