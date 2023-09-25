using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Foundation myFoundation = new Foundation();

            myFoundation.shade();

            Console.WriteLine( "the foundation is " + myFoundation.brand + " "+ myFoundation.modelName );
        }
    }
}
