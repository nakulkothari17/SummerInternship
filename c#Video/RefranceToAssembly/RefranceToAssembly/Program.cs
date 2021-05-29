using myLibarary;
using System;

namespace myClient
{
    class Program
    {
        static void Main(string[] args)
        {
            scrape myScrape = new scrape();
            Console.WriteLine(myScrape.ScrapeWebpage("https://www.google.com/webhp?hl=en&sa=X&ved=0ahUKEwif2KLopezwAhWM6nMBHSJgBckQPAgI"));
            Console.ReadLine();
        }
    }
}
