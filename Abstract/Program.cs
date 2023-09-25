using System;

namespace Abstract
{
    class Program
    {


        //public abstract class Animal
        //{


        //    public abstract string Sound { get;  }
        //    public virtual void Move()
        //    {
        //        Console.WriteLine("Its Movingg....");

        //    }
        //}
        //public class Cat : Animal
        //{
        //     public override string Sound => "meow";
        //    public override void Move()
        //    {
        //        Console.WriteLine("Walk like cat");
        //    }
        //}
        //public class Dog : Animal
        //{
        //    public override string Sound => "Vauuu";
        //    public override void Move()
        //    {
        //        Console.WriteLine("Run like a dog...");
        //    }
        //}




        static void Main(string[] args)
        {
            Animal[] animals = new Animal[] { new Cat(), new Dog() };
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"The { animal.GetType().Name} barks {animal.Sound}");
                animal.Move();
            }



        }
    }
}
