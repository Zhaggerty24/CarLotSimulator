using System;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
          CarLot lot = new CarLot();
            
            
            var Wheels = new Car();
            lot.CarList.Add(Wheels);

            Wheels.Make = "Hundai";
            Wheels.Model = "Sonata";
            Wheels.Year = 2005;

            Wheels.MakeEngineNoise();
            Wheels.MakeHonkNoise();

            var Wheels2 = new Car()
            {
                Make = "Nissan",
                Model = "GT-R",
                Year = 2023,
               
            };
            lot.CarList.Add(Wheels2);
            
            Wheels2.MakeEngineNoise();
            Wheels2.MakeEngineNoise();

            var Wheels3 = new Car("Honda", "Civic", 2022)
            {

            };
            lot.CarList.Add(Wheels3);
            
            Wheels3.MakeEngineNoise();
            Wheels3.MakeHonkNoise();

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}"); 

            foreach(var wheel in lot.CarList)
            {
                Console.WriteLine($"{Wheels.Make} {Wheels.Model} {Wheels.Year}");
                Console.WriteLine($"{Wheels2.Make} {Wheels2.Model} {Wheels2.Year}");
                
            }

            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
