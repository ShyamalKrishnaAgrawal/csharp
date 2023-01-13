using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography;

namespace TerminalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Environment.GetCommandLineArgs()
            string text;
            string[] links;
            if (args.Length == 0)
            {
                text = Console.ReadLine();
                links = text.Split(' ');
            }
            else
            {
                links = args;
            }

            switch (links[0]){
                case "Cat":
                    Cat(links[1]);
                    break;
                case "cat":
                    Cat(links[1]);
                    break;
                case "copy":
                    Copy(links[1], links[2]);
                    break;
                case "Copy":
                    Copy(links[1], links[2]);
                    break;
                case "count":
                    Count(links[1]);
                    break;
                case "Count":
                    Count(links[1]);
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    break;

            }

            //Console.ReadLine();
        }
        
        static void Cat(string link)
        {
            if (File.Exists(link))
            {
                // Read all the content in one string
                // and display the string
                string str = File.ReadAllText(@link);
                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine("File does not exsist");
            }
        }
        
        static void Copy(string link1, string link2)
        {
            //List<string> content = new List<string>();
            string context;
            if (File.Exists(link1))
            {
                // Read all the content in one string
                // and display the string
                string str = File.ReadAllText(@link1);
                //content.Add(str);
                context = str;
                if (!(File.Exists(@link2)))
                {
                    Console.WriteLine("File does not exsist");
                    Console.WriteLine("Creating file " + link2);
                }
                /*
                string str2 = File.ReadAllText(@link2);
                if (str2.Length > 0)
                {
                    Console.Write("Do you want to erase it: ");
                    switch (Console.ReadLine())
                    {
                        case "yes":
                            File.WriteAllText(@link2, string.Empty);
                            break;
                        case "Yes":
                            File.WriteAllText(@link2, string.Empty);
                            break;
                        case "no":
                            break;
                        case "No":
                            break;
                        default:
                            File.WriteAllText(@link2, string.Empty);
                            break;
                    }
                }
                */
                File.WriteAllText(@link2, string.Empty);
                File.AppendAllText(@link2, str);
            }
            else
            {
                Console.WriteLine("File does not exsist");
            }
        }

        
        static void Count(string link)
        {
            if (File.Exists(link))
            {
                // Read all the content in one string
                // and display the string
                int count = 0;
                string str = File.ReadAllText(link);
                string[] sentences= str.Split('\n');
                for(int i = 0; i < sentences.Length; i++)
                {
                    string[] words = sentences[i].Split(' ');
                    for (int j = 0; j < words.Length; j++)
                    {
                        switch (words[j]) 
                        {
                            case "":
                                break;
                            case ".":
                                break;
                            case ",":
                                break;
                            case "!":
                                break;
                            case "?":
                                break;
                            default:
                                count++;
                                break;
                        }
                    }
                }
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine("File does not exsist");
            }
        }
    }
}
