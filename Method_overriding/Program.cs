using System;

namespace Method_overriding
{
    class Program
    {


        class baseClass
        {
            public virtual void show()
            {
                Console.WriteLine("Base class");
            }
        }
        class derived : baseClass
        {
             public override void show()
            {
                Console.WriteLine("derived class");
            }
        }



        static void Main(string[] args)
        {
            baseClass obj = new baseClass();
            obj.show();
            obj = new derived();
            obj.show();


            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
        
    }

    
}
