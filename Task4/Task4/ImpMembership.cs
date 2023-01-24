using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{

    interface mem1
    {
        void silver();
    }
    interface mem2
    {
        void gold();
    }
    interface mem3
    {
        void platinum();
    }

    class Membership : mem1, mem2, mem3
    {
        public void silver()
        {
            Console.WriteLine("You will get 3 days accomodation at Resort");
        }
        public void gold()
        {
            Console.WriteLine("You will get 5 days accomodation at Resort and 2 Dinners on the house");
        }
        public void platinum()
        {
            Console.WriteLine("You'll get 7 days accomodation at Resort and 5 Dinners on the house");
        }
    }

    internal class ImpMembership
    {
        public static void Main()
        {

            Membership membership = new Membership();
            string membChoice;
            Console.WriteLine("Enter your membership:");
            membChoice = Console.ReadLine();
            switch (membChoice)
            {
                case "silver":
                    membership.silver();
                    break;

                case "gold":
                    membership.gold(); break;

                case "platinum":
                    membership.platinum(); break;

                default:
                    Console.WriteLine("Enter a proper membership");
                    break;
            }

        }
    }
}
