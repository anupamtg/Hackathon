using System;
using System.Collections.Generic;
using System.Text;

namespace Case_Study01_Analog_Watch
{
    class AnalogWatch : ICalendar
    {
        float baseprice=2000;
        public float strapType_price;

        public string MovingHands(string hands)
        {
            return hands;
        }
        public string StrapColor()
        {
            Console.WriteLine("Enter the Strap Color of your choice:");
            string color = Console.ReadLine().ToString();
            return color;
        }
        public float StrapTypeCost(int type)
        {
            if(type ==1)
            {
                strapType_price = 1000;
            }
            else
            {
                strapType_price = 500;
            }
            return strapType_price;
        }

        public bool HasCalendar(bool cal)
        {
            return true;
        }

      
    }

    
}
