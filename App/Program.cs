using App.Models;
using System;
using Newtonsoft.Json;
using App.Services.Implementation;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {

            var make = "empty";
            var model = "empty";
            var engineSizeString = "empty";
            var color = "empty";
            var yearString = "empty";
            var engineSize = 0.0;
            var year = 0000;


            while ( make == "empty" || make == "")
            {
                Console.WriteLine("Enter Car Manufacturer:");
                make = Console.ReadLine();
            }

            while ( model == "empty" || model == "")
            {
                Console.WriteLine("Enter Car Model:");
                model = Console.ReadLine();
            }

            while ( engineSizeString == "empty" || engineSizeString == "" )
            {
                Console.WriteLine("Enter Car Engine Size - example 2.0:");
                engineSizeString = Console.ReadLine();
                engineSize = Convert.ToDouble(engineSizeString);
                
            }

            while ( color == "empty" || color == "")
            {
                Console.WriteLine("Enter Car Color:");
                color = Console.ReadLine();
            }

            while ( yearString == "empty" || yearString == "" )
            {
                Console.WriteLine("Enter Car Manufactured Year - example 2020:");
                yearString = Console.ReadLine();
                year = int.Parse(yearString);
            }

            Car car = new Car()
            {
                Make = make,
                Model = model,
                EngineSize = engineSize,
                Color = color,
                Year = year
            };

            var mService = new MessageService();
            var messageSent = mService.PublishMessage(Newtonsoft.Json.JsonConvert.SerializeObject(car));
            if (!messageSent)
            {
                Console.Write("Error message not published!");
            }

            Console.WriteLine("Your car is a " + car.Color + " " + car.Make + " " + car.Model + "\nIt has a " + car.EngineSize + "L engine,\nand was built in " + car.Year);

        }
    }
}
