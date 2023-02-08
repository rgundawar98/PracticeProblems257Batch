using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch257
{
    public class FlipCoinPercentage
    {
        public static void FlipPercentage()
        {
            Console.WriteLine("Enter how many times the coin flip");
            int count = Convert.ToInt32(Console.ReadLine());
            int Headcount = 0;
            int Tailcount = 0;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    Random random = new Random();
                    int value = random.Next(2);
                    if (value == 0)
                    {
                        Headcount++;
                    }
                    else
                    {
                        Tailcount++;
                    }
                }
                Console.WriteLine("HeadCount will be:" + Headcount);
                Console.WriteLine("TailCount will be: " + Tailcount);

                int HeadPercentage = Headcount * 100 / count;
                int TailPercentage = Tailcount * 100 / count;
                Console.WriteLine("Head Count percentage will be:" + HeadPercentage + "%");
                Console.WriteLine("Tail count percentage will be:" + Tailcount + "%");
            }
            else
            {
                Console.WriteLine("Enter the inputs");
            }
        }

        //public static void flippercentage()
        //{
        //    Console.WriteLine("Enter how many times flip coin");
        //   // int count =Convert.ToInt32(Console.ReadLine());
        //   double count = Convert.ToDouble(Console.ReadLine());
        //    double tailcount=0;
        //    double headcount=0;
        //    if(count > 0)
        //    {
        //        for(int i=0; i<count; i++)
        //        {
        //           Random random= new Random();
        //           var value = random.NextDouble();
        //           if(value > 0.1)
        //            {
        //                tailcount++;
        //            }
        //            else
        //            {
        //                headcount++;
        //            }
        //        }
        //        Console.WriteLine(tailcount);
        //        Console.WriteLine(headcount);
        //    }

        //}
    }
}
