using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Id, Age, AccessInput = 5, UserNeed = 6;
            string Name;
            double Cgpa;
            bool VaccinatedStatus;

            List<IFixedDetails> PersonObjectList = new List<IFixedDetails>();
            List<IFixedDetails> PetObjectList = new List<IFixedDetails>();

            Console.WriteLine(" Welcome");

            while (AccessInput != 2)
            {
                Console.WriteLine(" Enter 0 to access person table \n Enter 1 to access pet table \n Enter 2 to exit ");
                Console.Write(" Input: ");
                AccessInput= Convert.ToInt32(Console.ReadLine());

                if (AccessInput == 2)
                {
                    break;
                }
                else if (AccessInput > 2)
                {
                    Console.WriteLine(" invalid input");
                }

                UserNeed = 6;
                
                while (UserNeed != 0) 
                { 
                    Console.WriteLine(" Enter 0 to exit ");
                    if (AccessInput == 0)
                    {

                        Console.WriteLine(" Enter 1 to add person table \n Enter 2 to edit person table \n Enter 3 to delete person table \n Enter 4 to display person table \n Enter 5 to save to file \n Enter 6 to exit");
                        Console.Write(" Please enter input= ");


                        UserNeed = Convert.ToInt32(Console.ReadLine());
                        if (UserNeed == 1)
                        {
                            // Add person details
                            Console.Write(" Enter person id= ");
                            Id = Convert.ToInt32(Console.ReadLine());
                            Console.Write(" Enter Person name= ");
                            Name = Console.ReadLine();
                            Console.Write(" Enter person age= ");
                            Age = Convert.ToInt32(Console.ReadLine());
                            Console.Write(" Enter person cgpa= ");
                            Cgpa = Convert.ToDouble(Console.ReadLine());
                            Person person = new Person();
                            person.Add(Id, Name, Age, Cgpa);
                            PersonObjectList.Add(person);

                        }
                        else if (UserNeed == 2)
                        {
                            // Edit person details
                            Console.Write(" Enter person id= ");
                            Id = Convert.ToInt32(Console.ReadLine());

                            Person person = new Person();
                            PersonObjectList = person.Edit(PersonObjectList, Id);

                        }
                        else if (UserNeed == 3)
                        {
                            // Delete a person details
                            Console.Write(" Enter person id= ");
                            Id = Convert.ToInt32(Console.ReadLine());
                            Person person = new Person();
                            PersonObjectList=person.Delete(PersonObjectList, Id);
                            

                        }
                        else if (UserNeed == 4)
                        {
                            // Person display details
                            Person person = new Person();
                            person.Display(PersonObjectList);
                        }
                        else if (UserNeed == 5)
                        {
                            // Write person table/details in file
                            string file = @"C:\Users\developer\Downloads\Person.txt";
                            Person person = new Person();
                            person.WriteToFile(file, PersonObjectList);
                        }
                        else if(UserNeed == 6)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(" Invalid input");
                        }
                        Console.WriteLine();
                    }
                    else if (AccessInput == 1)
                    {

                        Console.WriteLine(" Enter 1 to add pet table \n Enter 2 to edit pet table \n Enter 3 to delete pet table \n Enter 4 to display pet table \n Enter 5 to save to file \n Enter 6 to exit");
                        Console.Write(" Please enter input= ");


                        UserNeed = Convert.ToInt32(Console.ReadLine());
                        if (UserNeed == 1)
                        {
                            // Add pet details
                            Console.Write(" Enter pet id= ");
                            Id = Convert.ToInt32(Console.ReadLine());
                            Console.Write(" Enter pet name= ");
                            Name = Console.ReadLine();
                            Console.Write(" Enter pet age= ");
                            Age = Convert.ToInt32(Console.ReadLine());
                            Console.Write(" Enter pet vaccinated status= ");
                            VaccinatedStatus = Convert.ToBoolean(Console.ReadLine());
                            Pet pet = new Pet();
                            pet.Add(Id, Name, Age, VaccinatedStatus);
                            PetObjectList.Add(pet);

                        }
                        else if (UserNeed == 2)
                        {
                            // Edit pet details
                            Console.Write(" Enter pet id= ");
                            Id = Convert.ToInt32(Console.ReadLine());

                            Pet pet = new Pet();
                            PetObjectList = pet.Edit(PetObjectList, Id);
                        }
                        else if (UserNeed == 3)
                        {
                            // Delete pet details
                            Console.Write(" Enter pet id= ");
                            Id = Convert.ToInt32(Console.ReadLine());

                            Pet pet = new Pet();
                            PetObjectList = pet.Delete(PetObjectList, Id);
                        }
                        else if (UserNeed == 4)
                        {
                            // Display pet details
                            Pet pet = new Pet();
                            pet.Display(PetObjectList);
                        }
                        else if (UserNeed == 5)
                        {
                            // Write pet details in a file
                            string file = @"C:\Users\developer\Downloads\Pet.txt";
                            Pet pet = new Pet();
                            pet.WriteToFile(file, PetObjectList);
                        }
                        else if (UserNeed == 6)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(" Invalid input");
                        }
                        Console.WriteLine();
                    }
                }
        }
        Console.WriteLine(" Done");

        }
    }
}
