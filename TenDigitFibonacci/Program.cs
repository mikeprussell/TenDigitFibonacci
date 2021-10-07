using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;//added for ArrayList

namespace TenDigitFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Three variables are used to generate the Fibonacci sequence
            int n1 = 0;
            int n2 = 1;
            int n3;

            ArrayList fibolist = new ArrayList() { };

            for (int i = 1; i <= 1000000000; i++)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;

                fibolist.Add(n3);

                if (n3 > 1000000000)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{n3:n0} - {i}\n");
                    Console.WriteLine($"The index of the first term in the Fibonacci sequence to contain 10 digits is {fibolist.IndexOf(n3)}.\n");

                    Console.ResetColor();
                    i = 1000000001;
                }

            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ResetColor();
        }
    }
}
