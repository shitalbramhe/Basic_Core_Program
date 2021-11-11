using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_program
{
    internal class Power_two
    {
        public void Powertwo()
        {
            Console.WriteLine("Enter the value of power");
            int power = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Table of power of two");
            int num = 2, ans=1;
            for (int i = 1; i <=power; i++)
            {
                ans = ans * num;
                Console.WriteLine(ans);
            }
        }   
    }
}
