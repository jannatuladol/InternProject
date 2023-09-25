using System;

namespace ArrayApplication
{
    class Program
    {
        static void Main(string[] args)
        {
             string[] student = new string[] {"Maisha","Sruti",  "Prioty", "Jannat",
                                    "Roza", "Faria", "MIM" };
               int indexToPrint = 3;
            if (indexToPrint >= 0 && indexToPrint < student.Length)
            {
                Console.WriteLine($"in the index it have: {student[indexToPrint]} ");
            }

            //for (int i = 0; i < student.Length; i++)
            //{
            //    Console.WriteLine(student[indexToPrint]);
            //}


            //foreach (string name in student)
            //{
            //    //Console.WriteLine(name + " ");
            //}

            Console.Read();
        }
    }
}
