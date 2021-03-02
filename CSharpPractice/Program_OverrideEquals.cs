using System;

namespace CSharpPractice
{
    class Program_OverrideEquals
    {
        static void Main(string[] args)
        {

            var ob1 = new UserWithEquals()
            {
                FirstName = "r",
                LastName = "k"
            };
            var ob2 = new UserWithEquals()
            {
                FirstName = "r",
                LastName = "k"
            };



            var ob3 = new UserWithoutEquals()
            {
                FirstName = "r",
                LastName = "k"
            };
            var ob4 = new UserWithoutEquals()
            {
                FirstName = "r",
                LastName = "k"
            };


            Console.WriteLine(ob1 == ob2);
            Console.WriteLine(ob3 == ob4);

            Console.WriteLine(ob1.Equals(ob2));
            Console.WriteLine(ob3.Equals(ob4));


            Console.ReadLine();
        }


    }

    public class UserWithEquals
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override bool Equals(object obj)
        {
            var comparObj = (UserWithEquals)obj;
            return comparObj.FirstName == this.FirstName && comparObj.LastName == LastName;
        }
    }


    public class UserWithoutEquals
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

}
