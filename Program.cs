﻿namespace Is_number_prime
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(13));
        }
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            int boundary = (int)Math.Sqrt(number);
            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}







