using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch257
{
    public class Username
    {
        public static void DisplayUsername()
        {
            Console.WriteLine("Please input username");
            string username = Console.ReadLine();

            if (username.Length > 3)
            {
                Console.WriteLine("Hello " + username + " How are you?");
            }
            else
            {
                Console.WriteLine("Username must be three characters");
            }
        }
    }
}
