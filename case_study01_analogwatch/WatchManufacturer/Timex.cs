﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Case_Study01_Analog_Watch
{
    class Timex : AnalogWatch
    {
        public float timexbaseprice = 1000;
        
        public string checkcal()
        {
            string calendar;
            if (HasCalendar(true))
            {
                 calendar = "It has a calendar";
            }
            else
            {
                calendar = "It does not have a calendar";
            }
            return calendar;
        }
        public string MadeIn()
        {
            string TimexMadeIn = "Switzerland";
            return TimexMadeIn;
           
        }
        public float TotPrice()
        {
            Console.WriteLine("Enter 1 for metalic or 2 for leather");
            string choice = Console.ReadLine();
            int choice1or2 = Convert.ToInt32(choice);
            float result = StrapTypeCost(choice1or2) + timexbaseprice;
            return result;
        }


    }
}
