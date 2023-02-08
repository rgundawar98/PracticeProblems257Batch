using System;
using System.Diagnostics;

namespace Batch257
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your option from below");
            Console.WriteLine("1.Username display\n2.LeapYr\n3.FlipCoin Percentage\n4.Power of number\n5.HarmonicNumber" +
                "\n6.PrimeFactor");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Username.DisplayUsername();
                    break;
                case 2:
                    LeapYear.DisplayYear();
                    break;
                case 3:
                    FlipCoinPercentage.FlipPercentage();
                    break;
                case 4:
                    PowerOFNumber.Number();
                    break;
                case 5:
                    HarmonicNumber.Number_List();
                    break;
                case 6:
                    PrimeFactor.Num();
                    break;
            }


            //Console.WriteLine("Addition program");
            //Console.WriteLine("Enter the first number");
            //int val1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the second number");
            //int val2 = Convert.ToInt32(Console.ReadLine());
            //int val3 = val1 + val2;
            //Console.WriteLine("Addition will be:" + val3);
        }
    }
}
