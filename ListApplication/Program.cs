using System;
using System.Collections.Generic;

namespace ListApplication
{
    class StudentList
    {
        int Id;
        string Name;
        int Age;

        public StudentList(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;

        }



        static void Main(string[] args)
        {
            List<StudentList> students = new List<StudentList>();
            students.Add(new StudentList(101, "Jannat", 11));
            students.Add(new StudentList(102, "Maisha", 12));
            students.Add(new StudentList(103, "Toma", 13));
            students.Add(new StudentList(104, "MIM", 14));
            students.Add(new StudentList(105, "KOko", 15));

            Console.WriteLine("Student Information: ");
            foreach (var s in students ){
                Console.WriteLine($"Student ID is: {s.Id}, Student Name is : {s.Name}, Student Age is: {s.Age} ");

            }





            //List<int> studentlist = new List<int>();
            //studentlist.Add(1);
            //studentlist.Add(2);
            //studentlist.Add(3);
            //studentlist.Add(4);
            //studentlist.Add(5);





            //Console.WriteLine("capacity is : " + studentlist.Capacity);


            //Console.WriteLine("capacity is : " + studentlist.Count);

            //studentlist.Add(6);
            //studentlist.Add(7);
            //studentlist.Add(8);

            //Console.WriteLine("capacity is : " + studentlist.Capacity);

            //Console.WriteLine("capacity is : " + studentlist.Count);

            //Console.WriteLine("the Contains is : " + studentlist.Contains(4));

            //foreach (int K in studentlist)
            //{
            //    Console.WriteLine("All the student ID is : " + K + " ");
            //}


            //Console.WriteLine("Removing the element at index 3\n");

            //studentlist.RemoveAt(3);

            //foreach (int n in studentlist)
            //{
            //    Console.WriteLine("All the student ID is : " + n + " ");
            //}




        }
    }
}
