using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Task5a
    {
        string name;
        int age;

        //Implementing Polymorphism
        public Task5a()
        {
            name = "Padma";
            age = 21;
        }
        public Task5a(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public static void Main(string[] args)
        {
            Task5a obj = new Task5a();
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.age);
            Task5a bobj = new Task5a("Padma", 21);
               
            Console.WriteLine(bobj.name);
            Console.WriteLine(bobj.age);
        }

    }
}
