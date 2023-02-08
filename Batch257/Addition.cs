using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch257
{
    internal class Addition
    {
        public static void add()
        {
            Console.WriteLine("Addition program");
            Console.WriteLine("Enter the first number");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int val2 = Convert.ToInt32(Console.ReadLine());
            int val3 = val1 + val2;
            Console.WriteLine("Addition will be:" + val3);
        }
    }
}
