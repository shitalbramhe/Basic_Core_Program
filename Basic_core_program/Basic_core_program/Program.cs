using System;

namespace Basic_core_program
{
    public class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Welcome to basic core proogram");
            Console.WriteLine("Enter number  \n 1. Flip_Coin \n 2. Leap_year \n 3. Power of Two \n 4. Harmonic Number \n 5. Prime Factor \n 6. Compute Quotient and Remainder \n 7. Swap two numbers \n 8. Even odd  \n 9. Check Vowel consonant \n 10.  Largest among three number");
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
                case 7:
                    Swap_two_num Swap = new Swap_two_num();
                    Console.WriteLine("Enter first number");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Swap.Swaping(num1,num2);
                    break;
               case 8:
                    Check_Even_odd even_odd  = new Check_Even_odd();
                    Console.WriteLine("Enter number");
                    int number = Convert.ToInt32(Console.ReadLine());
                    even_odd.Evenodd(number);
                    break;
                case 9:
                    Check_Vowel_consonant vowelconsonant = new Check_Vowel_consonant();
                    Console.WriteLine("Enter charactor");
                    char alphabet = Convert.ToChar(Console.ReadLine());
                    vowelconsonant.vowel_consonant(alphabet);
                    break;
                case 10:
                    Largest_among_num large = new Largest_among_num();
                    Console.WriteLine("Enter first number");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter third number");
                    int number3 = Convert.ToInt32(Console.ReadLine());
                    large.largest_num(number1, number2, number3);
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
        }
    }
}
