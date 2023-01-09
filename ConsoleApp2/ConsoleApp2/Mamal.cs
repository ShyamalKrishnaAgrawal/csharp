using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Mamal : IFixedDetails
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        abstract public void Add(int id, string name, int age);

        abstract public List<IFixedDetails> Delete(List<IFixedDetails> RequiredObjectList, int Id);

        abstract public void Display(List<IFixedDetails> RequiredObjectList);

        abstract public List<IFixedDetails> Edit(List<IFixedDetails> RequiredObjectList, int Id);

        abstract public void WriteToFile(string file, List<IFixedDetails> RequiredObjectList);
    }
}
