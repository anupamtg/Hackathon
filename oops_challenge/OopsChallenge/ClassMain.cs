using System;
using System.Collections.Generic;
using System.Text;

namespace OopsChallenge
{
    class ClassMain
    {
        static void Main(string[] args)
        {
            string bchoice;
            Console.WriteLine("##### Bill's Burgers ######");
            Console.WriteLine("##### MENU ######");
            Console.WriteLine("Select Option:\n\n1.Regular Burger\n\n2.Healthy Burger\n\n3.Deluxe Burger");
            bchoice = Console.ReadLine()[0].ToString();
            if(bchoice=="1")
            {
                Burger B = new Burger("Chicken","Plain");
                B.BuildBurger();

            }
            else if(bchoice=="2")
            {
                HealthyBurger HB = new HealthyBurger("Healthy", "Brown Rye Bread");
                HB.BuildBurger();

            }
            else if(bchoice=="3")
            {
                DeluxeBurger DB = new DeluxeBurger("Deluxe", "Special Bread");
                DB.BuildBurger();
            }
            else
            {
                Console.WriteLine("Wrong input");
                
            }


           
           
        }
    }
}
