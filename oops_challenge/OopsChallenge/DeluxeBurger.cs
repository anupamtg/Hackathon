using System;
using System.Collections.Generic;
using System.Text;

namespace OopsChallenge
{
    class DeluxeBurger : Burger

    {
        float chipsprice = 60;
        float drinksprice = 50;
        float baseprice = 200;
     

        public DeluxeBurger(String brgname, String BRT)
        {
            this.BreadRollType = BRT;
            this.name = brgname;

        }

        public float BuildBurger()
        {
            
            Console.WriteLine("Cola and Chips");
            DeluxeBurger DB = new DeluxeBurger("Deluxe", "Special Bread Roll");
            
            return DB.Getfinalprice();

        }

        public new float Getfinalprice()
        {
            float finalprice = baseprice + chipsprice + drinksprice;
            Console.WriteLine("\n\nYour Bill amounts to:");
            Console.WriteLine(finalprice);
            return finalprice;
        }
    }
}
