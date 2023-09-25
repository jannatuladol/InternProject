using System;

namespace Maxvalue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 99, 100, 5, 94, 1009 };

            int mNumber = numbers[0];

            for(int i=1; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber > mNumber)
                {
                    mNumber = currentNumber;
                }

            }






            Console.WriteLine($"The MAX number is: " + mNumber);
        }
    }
}
