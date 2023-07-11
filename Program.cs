using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username;
        Again:
            Console.WriteLine("Enter the userName");
            username = Console.ReadLine();
            if (username.Length >= 6)
            {
                Console.WriteLine("Welcome : \t " + username);
            }
            else
            {
                Console.WriteLine("Invalid User Name");
                goto Again;
            }
            Console.ReadKey();
        }
    }
}
