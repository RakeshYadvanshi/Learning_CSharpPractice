using System;

namespace CSharpPractice
{
    public partial class UserServiceWithPartial
    {
        public string LastName { get; set; }


        partial void printLastName()
        {
            Console.WriteLine(LastName);
        }


    }
}
