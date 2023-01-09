using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface IFixedDetails
    {

        void Add(int id, string name, int age);
        List<IFixedDetails> Edit(List<IFixedDetails> RequiredObjectList, int Id);
        List<IFixedDetails> Delete(List<IFixedDetails> RequiredObjectList, int Id);

        void Display(List<IFixedDetails> RequiredObjectList);
        void WriteToFile(string file, List<IFixedDetails> RequiredObjectList);
        
    }
}
