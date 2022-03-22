using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Car : Motoredvehicle
    {
        public bool IsOn;


        public Car(string model, string make, string year) : base()
        {
            
        }



        public void TurnOn()
        {
            IsOn = true;
        }


        public void TurnOff()
        {
            IsOn = false;
        }


        public void Go(int distance)
        {
            GetDetailedInfo();
            int fuelvolume;
            fuelusedperkm = 10;
            fuelvolume = (distance / 100) * fuelusedperkm; //per 100km
            if (IsOn == true && fuelamount >= fuelvolume)
            {
                Console.WriteLine(distance + " " + "km mesafe qet edildi");
            }
            else
            {
                Console.WriteLine("kifayet qeder yanacaq yoxdur");
            }
        }
    }
}
