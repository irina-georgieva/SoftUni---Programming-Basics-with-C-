using System;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookname = Console.ReadLine();           
            int booksnum = 0;                       

            while(true)
            {
                string books = Console.ReadLine();
                if(books == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {booksnum} books.");
                    break;
                }
                    
                if (books == bookname)
                {
                    Console.WriteLine($"You checked {booksnum} books and found it.");                    
                    break;
                }               
                
                booksnum++;
            }          


        }
    }
}
