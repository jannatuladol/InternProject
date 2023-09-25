using System;

namespace StringEXample
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello C#";
            int a = 135;

            //*********To.String*******
            string s2 = s1.ToString(); // To.String
            string s3 = a.ToString();
            Console.WriteLine(s2);
            Console.WriteLine(s3);

            //*********Split*******
            string s4 = "i am Root";
            string[] s5 = s4.Split(' ');
            foreach(string s6 in s5)
            {
                Console.WriteLine(s6);
            }

            //*********convert*******
            //Parse
            string numString = "5";
            int e = int.Parse(numString);
            Console.WriteLine("CONVERT value of i: {0}", e );


            //ToInt32
            string numString2 = "135";
            int num = Convert.ToInt32(numString2);
            Console.WriteLine("The 3rd is: "+ num);


            //*********REPLACE*******

            string r1 = "Hello C#, Hello WORLD , Hello .Net";
            string r2 = r1.Replace("Hello", "Cheers");
            Console.WriteLine("The string is: "+ r1);
            Console.WriteLine("The REPLACE string is: " +  r2);

            //*********Trim*******
            string t1 = "Hello C#";
            //char[] ch = {"#"};
            string t2 = t1.Trim();
            Console.WriteLine("The Trim result  is: " + t2);


            //*********Single String Print*******

            string word = "Jannat";
            Console.WriteLine(" Individual Characters: ");

            foreach (char c in word)
            {
                Console.WriteLine(c);
            }


            //for (int i =0 ; i < word.Length; i++)
            //{
            //    char character = word[i];
            //    Console.WriteLine(character);
            //}


            //string d1 = "ADOOOL";
            //string[] d2 = d1.Split(" ");
            //foreach (string d3 in d2)
            //{
            //    Console.WriteLine(d3);
            //}


            Console.ReadLine();





        }
    }
}
