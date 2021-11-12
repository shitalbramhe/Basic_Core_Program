using System;

namespace Basic_core_program
{
    public class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Welcome to basic core proogram");
            Console.WriteLine("Enter number  \n 1. Flip_Coin \n 2. Leap_year \n 3. Power of Two \n 4. Harmonic Number \n 5. Exit");
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
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
        }
    }
}
