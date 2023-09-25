using System;

namespace Encapsulation
{
     class User
    {
        private string studentName;
        private int studentID;

        public String Name
        {

            get { return studentName; }

            set { studentName = value; }
        }
        public int ID
        {

            get { return studentID; }

            set { studentID = value; }
        }

    }

    class program
        {
        static void Main(string[] args)
        {

            User u = new User();
            u.Name = "Anika";
            u.Name = "KARIM";
            u.ID = 102;

            Console.WriteLine(" Student Name is  : " + u.Name);
            Console.WriteLine(" ID : " + u.ID);


        }
        }
        
    
}
