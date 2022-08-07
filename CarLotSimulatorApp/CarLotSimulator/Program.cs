using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();
            
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var honda = new Car();
            honda.Make = "Honda";
            honda.Model = "Accord";
            honda.Year = 2020;
            honda.EngineNoise = "quiet";
            honda.HonkNoise = "loud";
            honda.IsDriveable = true;

            lot.Cars.Add(honda);

            var genesis = new Car()
            {
               Year = 2018,
               Make = "Genesis",
               Model = "G90",
               EngineNoise = "quiet",
               HonkNoise = "smooth",
               IsDriveable = true,
            };

            lot.Cars.Add(genesis);

            var infiniti = new Car(2014, "Infiniti", "QX80", "loud", "loud", true);

            lot.Cars.Add(infiniti);

            honda.MakeEngineNoise();
            genesis.MakeEngineNoise();
            infiniti.MakeEngineNoise();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            
            foreach(var item in lot.Cars)
            {
                Console.WriteLine($"Year:{item.Year} Make:{item.Make} Model:{item.Model}");
            }
        }
    }
}
