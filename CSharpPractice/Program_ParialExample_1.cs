using System;

namespace CSharpPractice
{
    class Program_ParialExample
    {
        static void Main1(string[] args)
        {

            var ob1 = new UserServiceWithPartial()
            {
                FirstName = "r",
                LastName = "k"
            };
            ob1.FullName();
            Console.ReadLine();
        }


    }

    public partial class UserServiceWithPartial
    {


        public void FullName()
        {
            printFirstName();
            printLastName();
        }
        public string FirstName { get; set; }
        partial void printFirstName()
        {

            Console.WriteLine(FirstName); ;
        }

    }


}
