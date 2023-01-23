using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class DispName
    {
        public static void Main()
        {
            string name;
            int age;
            Console.WriteLine("Enter your Name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter your Age:");
            age = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=age; i++)
            {
                Console.WriteLine(name);
            }
        }
    }
}
