using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_program
{
    internal class Check_Even_odd
    {
        public void Evenodd(int number)
        {
            if (number % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }
        }
    }
}
