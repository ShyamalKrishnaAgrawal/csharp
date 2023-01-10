using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Person :Mamal
    {
        public double Cgpa { get ; set; }

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

        public void Add(int Id, string Name, int Age, double Cgpa)
        {
            this.Cgpa = Cgpa;
            Add(Id, Name, Age);
        }

        public override List<IFixedDetails> Edit(List<IFixedDetails> RequiredObjectList, int Id)
        {
            foreach (Person person in RequiredObjectList)
            {
                if (Id == person.id)
                {
                    Console.Write(" Enter name of person = ");
                    person.name = Console.ReadLine();
                    Console.Write(" Enter age of person = ");
                    person.age = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" Enter cgpa of person = ");
                    person.Cgpa = Convert.ToDouble(Console.ReadLine());
                    break;
                }
            }
            return (RequiredObjectList);
        }

        public override List<IFixedDetails> Delete(List<IFixedDetails> RequiredObjectList,  int Id)
        {
            int Count = 0;
            foreach(Person person in RequiredObjectList)
            { 
                if(person.id== Id)
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
            Console.WriteLine("| Id | Name | Age | CGPA |");
            foreach (Person person in RequiredObjectList)
            {
                Console.WriteLine("| " + person.id + " |" + person.name + " |" + person.age + " |" + person.Cgpa + " |");
            }
        }

        public override void WriteToFile(string file, List<IFixedDetails> RequiredObjectList)
        {

            // Appending the given texts
            using (StreamWriter sw = File.AppendText(file))
            {
                sw.WriteLine("| Id | Name | Age | CGPA |");
            }

            foreach (Person person in RequiredObjectList)
            {
                File.AppendAllText(file, "| " + person.id + " |" + person.name + " |" + person.age + " |" + person.Cgpa + " |");
            }
        }
    }
}
