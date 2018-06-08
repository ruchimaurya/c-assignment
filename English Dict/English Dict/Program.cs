using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] engdict = new string[] { "Boat","house","cat","river", "cupboard" };

            foreach (string var in engdict)
                Console.WriteLine(var + "s");
            print();

            engdict[1] = "Home";
            print();

            Array.Resize(ref engdict, engdict.Length+1);
            engdict[engdict.Length - 1] = "tree";

            Console.WriteLine("Length of array:"+ engdict.Length);

            //print word of 7 lenght

            foreach(string i in engdict)
                if(i.Length==7)
                {
                    Console.WriteLine("Word having lenght 7:" + i);
                }

            Console.WriteLine("Word at 3rd pos:" + engdict[2]);
            //sort an array
            Array.Sort<string>(engdict);

            print();

            Array.Reverse(engdict);
            print();

            Console.Read();

            void print()
            {
                foreach (string a in engdict)
                    Console.WriteLine(a);
            }
        }
    }
}
