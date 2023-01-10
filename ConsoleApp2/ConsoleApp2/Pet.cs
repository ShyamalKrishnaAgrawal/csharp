using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
    internal class Pet: Mamal
    {
        public bool vaccinatedStatus;

        public void SetData(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public override void Add(int id, string name, int age)
        { 
            SetData(id, name, age);
        }

        public void Add(int id, string name, int age, bool vaccinatedStatus)
        {
            Add(id, name, age);
            this.vaccinatedStatus = vaccinatedStatus;
        }

        public override List<IFixedDetails> Edit(List<IFixedDetails> RequiredObjectList, int Id)
        {
            foreach (Pet pet in RequiredObjectList)
            {
                if (Id == pet.id)
                {
                    Console.Write(" Enter name of pet = ");
                    pet.name = Console.ReadLine();
                    Console.Write(" Enter age of pet = ");
                    pet.age = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" Enter vaccinated status of pet = ");
                    pet.vaccinatedStatus = Convert.ToBoolean(Console.ReadLine());
                    break;
                }
            }
            return (RequiredObjectList);
        }

        public override List<IFixedDetails> Delete(List<IFixedDetails> RequiredObjectList, int Id)
        {
            int Count = 0;
            foreach (Pet pet in RequiredObjectList)
            {
                if (pet.id == Id)
                {
                    RequiredObjectList.RemoveAt(Count);
                    break;
                }
                Count++;
            }
            return (RequiredObjectList);
        }

        public override void Display(List<IFixedDetails> RequiredObjectList)
        {
            Console.WriteLine("| Id | Name | Age | Vaccinated Status |");
            foreach (Pet pet in RequiredObjectList)
            {
                Console.WriteLine("| " + pet.id + " |" + pet.name + " |" + pet.age + " |" + pet.vaccinatedStatus + " |");
            }
        }

        public override void WriteToFile(string file, List<IFixedDetails> RequiredObjectList)
        {

            // Appending the given texts
            using (StreamWriter sw = File.AppendText(file))
            {
                sw.WriteLine("| Id | Name | Age | CGPA |");
            }

            foreach (Pet pet in RequiredObjectList)
            {
                File.AppendAllText(file, "| " + pet.id + " |" + pet.name + " |" + pet.age + " |" + pet.vaccinatedStatus + " |");
            }
        }
    }
}
