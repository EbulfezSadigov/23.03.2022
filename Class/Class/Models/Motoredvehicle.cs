using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Motoredvehicle
    {
        public string model;
        public string make;
        public string productionyear;
        public string motorsize;
        public int fueltanksize;
        public int fuelamount;
        public int fuelusedperkm;
        public string color;
        public string transmission;
        public string horsepower;
        public string Passengercount;

        public Motoredvehicle()
        {
            color = "red";
            horsepower = "301-hp";
            Passengercount = "4";
        }


        public Motoredvehicle(string model,string make,string year)
        {
            this.model = model;
            this.make = make;
            this.productionyear = year;
        }
        


        public void GetInfo()
        {
            Console.WriteLine("Car's model is"+" "+model);
            Console.WriteLine("Car made in"+" "+make);
            Console.WriteLine("Car products in"+" "+productionyear);
        }



        public void GetDetailedInfo()
        {
            fuelamount = 60;
            Console.WriteLine("Car's fuelamount is"+" "+fuelamount);
        }
    }
}
