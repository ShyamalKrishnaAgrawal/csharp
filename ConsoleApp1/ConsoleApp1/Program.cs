using Microsoft.Win32;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello world and";
            int i = 5;
            char g = 'a';
            double d = 3.3;
            bool b = true;
            Console.WriteLine(s);
            Console.WriteLine(i);
            Console.WriteLine(g);
            Console.WriteLine(d);
            Console.WriteLine(b);
            Console.WriteLine("Hello world");
            Console.WriteLine(s.Length);
            
            
            Console.WriteLine("Hello world".ToUpper());
            Console.WriteLine(s.Substring(s.IndexOf("world")));
            Console.WriteLine(5.0 / 4);

            Console.Write("enter name= ");
            string name1 = Console.ReadLine();
            Console.WriteLine(name1 + 6);

            Console.Write("enter number= ");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + 6);

            int[] arr = { 1, 3, 5, 6, 7, 8, 9 };
            string[] arr2 = new string[5];

            // Console.WriteLine(Convert.ToString(arr));
            for(int i1= 0; i1 < arr.Length; i1++)
            {
                Console.WriteLine(arr[i1]);
            }

            Console.WriteLine("hi");


            Console.WriteLine(string.Equals("hello","hello"));

            say();

            int[,] arr4= { { 1, 2 }, { 3, 4}, { 5, 6} };
            int[,] arr3 = new int[5,2];

            try
            {
                int a = 3;
                Console.Write("Input b: ");
                int b2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a/b2);
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }


            Book book1= new Book("hellot", "helloa", 200, "R");
            book1.Rating = "R";
            Console.WriteLine(book1.title + " " + book1.author + " " + book1.pages + " " + book1.Rating);
            Console.WriteLine(Book.bookCount);

            //UsefulTools tool = new UsefulTools();
            UsefulTools.hi("mike");


            /*List<string> authors = new List<string>();
            authors.Add("Mahesh Chand");
            authors.Add("Chris Love");
            authors.Add("Allen O'neill");
            authors.Add("Naveen Sharma");
            authors.Add("Monica Rathbun");
            authors.Add("David McCarter");
            Console.WriteLine("Count: " + authors.Count);
            Console.WriteLine("Capacity: " + authors.Capacity);*/

            // Folder, where a file is created.  
            // Make sure to change this folder to your own folder  
            string folder = @"C:\Users\developer\Downloads\";
            // Filename  
            string fileName = "CSharpCornerAuthors.txt";
            // Fullpath. You can direct hardcode it if you like.  
            string file = @"C:\Users\developer\Downloads\CSharpCornerAuthors.txt";
            // An array of strings  
            string[] authors = {"Mahesh Chand", "Allen O'Neill", "David McCarter",
"Raj Kumar", "Dhananjay Kumar"};
            // Write array of strings to a file using WriteAllLines.  
            // If the file does not exists, it will create a new file.  
            // This method automatically opens the file, writes to it, and closes file  
            File.WriteAllLines(file, authors);
            //File.WriteAllText(file, authors);
            // Read a file  
            //string readText = File.ReadAllText(fullPath);
            //Console.WriteLine(readText);

            // Opening the file for reading
            using (StreamReader sr = File.OpenText(myfile))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            // Use write for same line
            // use double instead of integer its better
            Console.ReadLine();

            /*
             * book1.title= "hello";
             * book1.author= "hello";
             * book1.pages = 200;*/

            /*
             * multi line comments
             * 
             * multipe catches can be used
             * catch(<type of error want to catch> e)
             * {
             *  Console.WriteLine(e.Message);
             * }
             */

        }

        static void say()
        {
            Console.WriteLine("hi");
        }
    }
}
