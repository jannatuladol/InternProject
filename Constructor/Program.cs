using System;

namespace Constructor
{
    class Bag
    {
        public string model;
        public string color;
        public int year;


        public Bag(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }

        static void Main(string[] args)
        {
            Bag bag = new Bag("Gucci","BabyPink", 102);
            

         Console.WriteLine("The bag name is: " + bag.model + " "+ "The model is: "+ bag.color + " " + "The year is: "+ bag.year);
        }
    }
}
