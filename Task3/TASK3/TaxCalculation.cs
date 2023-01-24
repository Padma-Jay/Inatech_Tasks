using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class TaxCalculation //Base Class
    {
        public void VAT(int amt)
        {
            double t1 = 0;
            t1 = 0.2 * amt;
            Console.WriteLine("VAT tax is {0}", t1);

        }
    }
        class Tax : TaxCalculation //Derived Class
    {
        public void GST(int amt)
        {
            double t2 = 0;
            t2 = 0.12 * amt;
            Console.WriteLine("GST tax is {0}", t2);
        }
    }
         class ImpTax
    {
        public static void Main()
        {

            Tax obj = new Tax();
            obj.VAT(1000);
            obj.GST(1000);

        }
    }
}
