using System;

namespace Basic_core_program
{
    public class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Welcome to basic core proogram");
            Console.WriteLine("Enter number  \n 1. Flip_Coin \n 2. Leap_year \n 3. Power of Two \n 4. Harmonic Number \n 5. Prime Factor \n 6. Compute Quotient and Remainder");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Flip_Coin Flip = new Flip_Coin();
                    Flip.Checkpercentage();
                    break;
                case 2:
                    Leap_year Leap = new Leap_year();
                    Leap.Check_leap_year();
                    break;
                case 3:
                    Power_two Power = new Power_two();
                    Power.Powertwo();
                    break;
                case 4:
                    Harmonic Harnum = new Harmonic();
                    Harnum.Harmonic_number();
                    break;
                case 5:
                    Prime_factor prime = new Prime_factor();
                    int num = Convert.ToInt32(Console.ReadLine()); 
                    prime.Factorization(num);
                    break;
                case 6:
                    Comp_quotient Remainder = new Comp_quotient();
                    Console.WriteLine("Enter value of dividend");
                    int dividend = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter value of divisor");
                    int divisor = Convert.ToInt32(Console.ReadLine());
                    Remainder.Quotientremainder(dividend,divisor);
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
        }
    }
}
