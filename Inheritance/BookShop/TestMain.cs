using System;
using BookShop.Models;

namespace BookShop
{
    public class TestMain
    {
        public static void Main()
        {
            string author = Console.ReadLine();
            string title = Console.ReadLine();
            decimal price = Decimal.Parse(Console.ReadLine());

            try
            {
                Book book = new Book(author, title, price);
                GoldenEditionBook gBook = new GoldenEditionBook(author, title, price);

                Console.WriteLine(book);
                Console.WriteLine(gBook);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
