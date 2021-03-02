using System;
using System.Collections;
using System.Collections.Generic;

namespace OopsChallenge
{
    public class Burger
    {
        public string name;
        public float baseprice;
        public string BreadRollType;
        public bool meat;
        //public string LT,TO,CR,ON;
        public float LTPrice = 10;
        public float TOPrice = 15;
        public float CRPrice = 20;
        public float ONPrice = 25;

        public Burger()
            {
            } 

		public Burger(String brgname , String BRT)
				 {
					this.BreadRollType = BRT;
					baseprice = 100;
					meat = true;
					this.name = brgname;
				
				 }
		float addprice = 0;

		public void addAdditions(bool lettuce, bool tomato, bool carrot, bool onion)
		{
			Console.WriteLine("Additional additions you added: ");
			if (lettuce == true)
			{
				addprice += LTPrice;
				Console.WriteLine("LETTUCE");
			}
			if (tomato == true)
			{
				addprice += TOPrice;
				Console.WriteLine("TOMATO");
			}
			if (carrot == true)
			{
				addprice += CRPrice;
				Console.WriteLine("CARROT");
			}
			if (onion == true)
			{
				addprice += ONPrice;
				Console.WriteLine("ONION");
			}
		}
		public float Getfinalprice()
        {
            float finalprice = addprice + baseprice;
            Console.WriteLine("\n\nYour Bill amounts to:");
            Console.WriteLine(finalprice);
            return finalprice;
        }

		public float BuildBurger()
        {
            Console.WriteLine("Do you want to add..(y/n)");
            Console.WriteLine("lettuce:");
            char l = Console.ReadLine()[0];
            Console.WriteLine("Tomatto:");
            char t = Console.ReadLine()[0];
            Console.WriteLine("Carrot:");
            char c = Console.ReadLine()[0];
            Console.WriteLine("Onion:");
            char o = Console.ReadLine()[0];
            bool let, car, on, tom;
            if (l == 'y')
            {
                let = true;
            }
            else
            {
                let = false;
            }

            if (t == 'y')
            {
                tom = true;
            }
            else
            {
                tom = false;
            }

            if (o == 'y')
            {
                on = true;
            }
            else
            {
                on = false;
            }

            if (c == 'y')
            {
                car = true;
            }
            else
            {
                car = false;
            }


            Burger newburger = new Burger("Chicken", "PlainRoll");
            newburger.addAdditions(let, tom, car, on);
            return newburger.Getfinalprice();
            
        }
	}
		
	
	
}
