using System;
using System.Collections.Generic;
using System.Text;

namespace OopsChallenge
{
      class HealthyBurger : Burger

    {
        public float bp = 150;
		public float SPPrice = 50;
		public float OLPrice = 30;
		float addprice = 0;

        public HealthyBurger(String brgname, String BRT)
        {
            this.BreadRollType = BRT;
            this.name = brgname;

        }




        public void addAdditions(bool lettuce, bool tomato, bool carrot, bool onion, bool spinach, bool olives)
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
			if (spinach == true)
			{
				addprice += SPPrice;
				Console.WriteLine("SPINACH");
			}
			if (olives == true)
			{
				addprice += OLPrice;
				Console.WriteLine("OLIVE");
			}
		}

		public new float Getfinalprice()
		{
			float finalprice = addprice + bp;
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
            Console.WriteLine("Spinach:");
            char spin = Console.ReadLine()[0];
            Console.WriteLine("Olive:");
            char oliv = Console.ReadLine()[0];
            bool let, car, on, tom,spina,olive;
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



            if (spin == 'y')
            {
                spina = true;
            }
            else
            {
                spina = false;
            }

            if (oliv == 'y')
            {
                olive = true;
            }
            else
            {
                olive = false;
            }



            HealthyBurger newburger = new HealthyBurger("Healthy", "Brown Rye Bread Roll");
            newburger.addAdditions(let, tom, car, on,spina,olive);
            return newburger.Getfinalprice();

        }


    }
}
