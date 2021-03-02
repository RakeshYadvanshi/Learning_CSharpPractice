using System;

namespace CSharpPractice
{
    class Program_ToString
    {
        static void Main1(string[] args)
        {

            var ob1 = new UserWithToString()
            {
                FirstName="r",
                LastName="k"
            };


            var ob2 = new UserWithoutToString()
            {
                FirstName = "r",
                LastName = "k"
            };
            Console.WriteLine(ob1);
            Console.WriteLine(ob2);


            Console.ReadLine();
        }


    }

    public class UserWithToString
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }

    class UserWithoutToString
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

       
    }
}
