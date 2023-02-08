using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch257
{
    public class HarmonicNumber
    {
        public static void Number_List()
        {
            Console.WriteLine("Enter the number how much harmonic numbers want");
            double value =Convert.ToDouble(Console.ReadLine());
            double result = 0;
            for(double i=1; i<value; i++)
            {
                result = result + 1 / i;
            }
             Console.WriteLine("Harmonic number list : "+result);
        }
    }
}
