using System;

namespace MySecondOOPCode_Saturday
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            HumanPoweredVehicle humanPoweredVehicleObject = new HumanPoweredVehicle()
            {
                 Brand = "Chevrolet",
                 Model = "2015",
                 Reference = "Humano",
                 EnvironmentalSubsidy = 16000000.56M,

            };
            /*;
            humanPoweredVehicleObject.Brand = "Chevrolet";
            humanPoweredVehicleObject.Reference = "Humano";
            humanPoweredVehicleObject.EnvironmentalSubsidy = 1600000;*/


            Console.WriteLine(humanPoweredVehicleObject.ToString());


            Console.WriteLine("");
        }
    }
}
