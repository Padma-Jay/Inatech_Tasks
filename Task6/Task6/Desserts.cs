using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Desserts
    {
        public static void Main()
        {

            ArrayList dsrts = new ArrayList();
            dsrts.Add("Sundae");
            dsrts.Add("Pudding");
            dsrts.Add("Gulab Jamun");
            dsrts.Add("Mousse ");
            dsrts.Add("Pie");

            //Access the file, read the data and display the items.

            FileStream fs = new FileStream("C:\\Users\\PADMAVATHY\\OneDrive\\Inatech\\DAY5\\Task6\\desserts.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            foreach(object i in dsrts) 
                sw.WriteLine(i);
            sw.Flush();
            sw.Close();
            fs.Close();

            //Display the time of creation of file and size of file.

            FileInfo info = new FileInfo("C:\\Users\\PADMAVATHY\\OneDrive\\Inatech\\DAY5\\Task6\\desserts.txt");
            Console.WriteLine("Creation Time : {0}", info.CreationTime);
            Console.WriteLine("Size : {0}", info.Length);



        }
    }
}
