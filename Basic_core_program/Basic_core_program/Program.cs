using System;

namespace Basic_core_program
{
    public class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Welcome to basic core proogram");
            Console.WriteLine("Enter number  \n 1. Flip_Coin \n 2. Leap_year \n 3. Exit");
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

                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
        }
    }
}
