using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch257
{
    internal class PrimeFactor
    {
        public static void Num()
        {
            Console.WriteLine("Enter the number to check prime factor");
            int number = Convert.ToInt32(Console.ReadLine());
            int a = 2;
            while(number>1)
            {
                if(number % a ==0)
                {
                    Console.WriteLine("prime factors :{0}",a);
                    number = number / a;
                }
                else
                {
                    a++;
                }
            }
        }
    }
}