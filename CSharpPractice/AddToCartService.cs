using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{

    class Program_Overloading
    {
        static void Main1(string[] args)
        {

            var service = new AddToCartService();


            service.AddToCart(1, 8);
            service.AddToCart(1);


            service.AddToCart("sdfl");/// dis 1
            service.AddToCart("sdfl", 120); // dis 120

            service.AddToCart(1, 120, 10); // dis 120

            service.AddToCart(1, addOnId5: 2); // dis 120
            Console.ReadLine();
        }


    }
    public class AddToCartService
    {

        public void AddToCart(string productName, decimal discount = 1)
        {

        }


        public void AddToCart(int ucnId, decimal discount = 1, int addOnId = 0)
        {


        }

        public void AddToCart(int ucnId, decimal discount = 1, int addOnId = 0, int addOnId2 = 0, int addOnId3 = 0, int addOnId5 = 0)
        {


        }
        public void AddToCart(int productId)
        {

        }

        public void AddToCart(int productId, decimal discount)
        {

        }



        public abstract class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public abstract bool DoesPersonLikeHeels();
            public abstract bool DoesPersonLikeCars();

        }

        public class Male : Person
        {
            public override bool DoesPersonLikeCars()
            {
                return false;
            }

            public override bool DoesPersonLikeHeels()
            {
                return false;
            }
        }


        public class Female : Person
        {
            public override bool DoesPersonLikeCars()
            {
                return false;
            }

            public override bool DoesPersonLikeHeels()
            {
                return false;
            }
        }






    }
}
