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
                "\n6.PrimeFactor\n7.Addition");
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
                case 7:
                    Addition.add();
                    break;
            }
        }
    }
}
