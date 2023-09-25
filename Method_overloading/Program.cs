using System;

namespace Method_overloading
{
    class  Cal
    {
        

            static int add(int a, int b)
            {
                return a + b;
            }
            static double add(double a, double b)
            {
                return a + b;
            }
        
        static void Main(string[] args)
        {


            Console.WriteLine(Cal.add(12, 23));
            Console.WriteLine(Cal.add(12.5,23.5));

        }
    }
}
