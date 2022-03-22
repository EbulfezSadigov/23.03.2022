using System;

namespace Class
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Motoredvehicle vehicle1 = new Motoredvehicle("Toyota","Camry","1982");
            vehicle1.GetInfo();


         
            Motoredvehicle vehicle = new Motoredvehicle();
            Console.WriteLine("Car's color is"+" "+vehicle.color);
            Console.WriteLine("Car' horse power is"+" "+vehicle.horsepower);
            Console.WriteLine("Car's passenger count is"+" "+vehicle.Passengercount);



            Car veh = new Car("Toyota", "Camry", "1982");
            veh.TurnOn();
            veh.Go(250);

        }
    }
}
