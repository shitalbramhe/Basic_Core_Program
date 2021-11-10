using System;

namespace Basic_core_program
{
    internal class Flip_Coin
    {
        public int head = 0;
        public int tail = 0;
        public int percentagehead = 0;
        public int percentagetail = 0;
        public void Checkpercentage()
        {
            Console.WriteLine("Enter number of times you want to flip coin");
            int flip_number = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

            for (int i = 0; i < flip_number; i++)
            {
                double checkflip = random.Next(0, 2);
                if (checkflip < 0.5)
                {
                    Console.WriteLine("Tail");
                    tail++;
                }
                else
                {
                    Console.WriteLine("Head");
                    head++;
                }
            }
            percentagehead = head * (100 / flip_number);
            percentagetail = tail * (100 / flip_number);
            Console.WriteLine("Percentage of head :" + percentagehead+" Percentage of tail:" + percentagehead);
            Console.ReadKey();
        }
    }
}
