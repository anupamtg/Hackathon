using System;

namespace Case_Study01_Analog_Watch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a Watch Company" + Environment.NewLine + "1:Timex" + Environment.NewLine + "2:Titan" + Environment.NewLine + "3:FastTrack");
            string companychoice = Console.ReadLine();
            int compch = Convert.ToInt32(companychoice);
            if(compch==1)
            {
                Timex timex = new Timex();
                string movinghands =timex.MovingHands("Moving Hands 3");
                string strapcolor = timex.StrapColor();
                float price = timex.TotPrice();
                Console.WriteLine("Timex Watch Details");
                Console.WriteLine(movinghands);
                Console.WriteLine("Strap Color:");
                Console.WriteLine(strapcolor);
                string checkcal = timex.checkcal();
                Console.WriteLine(checkcal);
                Console.WriteLine("Total Price:");
                Console.WriteLine(price);


            }

            if (compch == 2)
            {
                Titan titan = new Titan();
                string movinghands = titan.MovingHands("Moving Hands 3");
                string strapcolor = titan.StrapColor();
                float price = titan.TotPrice();
                Console.WriteLine("Titan Watch Details");
                Console.WriteLine(movinghands);
                Console.WriteLine("Strap Color:");
                Console.WriteLine(strapcolor);
                string checkcal = titan.checkcal();
                Console.WriteLine(checkcal);
                Console.WriteLine("Total Price:");
                Console.WriteLine(price);


            }

            if (compch == 3)
            {
                FastTrack ft = new FastTrack();

                string movinghands = ft.MovingHands("Moving Hands 3");
                string strapcolor = ft.StrapColor();
                float price = ft.TotPrice();
                Console.WriteLine("FastTrack Watch Details");
                Console.WriteLine(movinghands);
                Console.WriteLine("Strap Color:");
                Console.WriteLine(strapcolor);
                string checkcal = ft.checkcal();
                Console.WriteLine(checkcal);
                Console.WriteLine("Total Price:");
                Console.WriteLine(price);


            }


        }
    }
}
