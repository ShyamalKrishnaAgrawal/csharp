using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;
        private string rating;
        public static int bookCount=0;

        public Book(string cti,string cau, int cpg, string crating)
        {
            title = cti;
            author = cau;
            pages = cpg;
            rating = crating;
            bookCount++;
            Console.WriteLine("constructor");
            Console.WriteLine(title + " " + author + " " + pages);
        }

        public string Rating
        {
            get { return rating; 
            }
            set 
            { 
                if(value == "G" || value == "R")
                {
                    rating = value;
                }
                else
                {
                    Rating = "NR";
                }
            }
        }
    }
}
