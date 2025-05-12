using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGD208_Assignment
{
    internal class pets
    {
        public string Name;
        public string Species;
        public string Figure;


        public void Meeting()
        {
            Console.WriteLine("Now you can see me.");
            Console.WriteLine();
            Console.WriteLine($"The cards gave me the name {Name}. I am {Species}.");
            Console.WriteLine($"{Figure}");

        }

            


    }
}
