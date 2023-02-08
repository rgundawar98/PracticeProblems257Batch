using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch257
{
    public class PowerOFNumber
    {
        public static void Number()
        {
            int result = 1;
            Console.WriteLine("Enter the number for making Power");
            int value =Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=value;i++)
            {
                result = result * i;
                Console.WriteLine(result);
            }
        }
    }
}
