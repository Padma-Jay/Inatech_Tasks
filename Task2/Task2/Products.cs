using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Products
    {
        public static void Main()
        {

            string[][] Pro = new string[4][];

            Pro[0] = new string[3] { "List", "Category", "No of Items" };
            Pro[1] = new string[3] { "a.", "Biscuits", "There are 4 items" };
            Pro[2] = new string[3] { "b.", "Chocolates", "There are 3 items" };
            Pro[3] = new string[3] { "c.", "Drinks", "        There are 6 items" };

            
            for (int i = 0; i < Pro.Length; i++)
            {
                for (int j = 0; j < Pro[i].Length; j++)
                    Console.Write(Pro[i][j] + "\t");

                Console.WriteLine();
            }
        }
    }
}
