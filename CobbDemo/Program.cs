using System;

namespace CobbDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Subaru WRX
            var SubaruWRX = new Car("Subaru", "WRX", 2.0, 2018, 268);
            //Display vehicle information to user
            Console.WriteLine("The current vehicle selected is a {0} {1} {2} with a {3:0.0}L engine.", SubaruWRX.Year, SubaruWRX.Make, SubaruWRX.Model, SubaruWRX.Engine);
            Console.WriteLine("The horsepower prior to a tune is {0}", SubaruWRX.HP + ".");
            //Prompt user for stage tune
            bool selected = false;
            int stage;
            do
            {
                Console.WriteLine("Please enter the stage of tune you would like to apply(1 - 2): ");
                stage= Int32.Parse(Console.ReadLine());
                if (stage < 1 || stage > 2)
                {
                    Console.WriteLine("Invalid stage selected. Please try again.");
                }
                else
                {
                    selected = true;
                }
            } while (selected == false);
            AdjustHorsepower.IncreaseHorsepower(SubaruWRX, stage);
            //Display updated horsepower for vehicle
            Console.WriteLine("With a stage {0} tune, the horsepower is now {1}.", stage, SubaruWRX.HP);
        }
    }

    //Car() class
    //Car contains the following properties: Make, Model, Engine, and Naturally Aspired.
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Engine { get; set; }
        public int Year { get; set; }
        public double HP { get; set; }

        public Car(string Make, string Model, double Engine, int Year, int HP)
        {
            this.Make = Make;
            this.Model = Model;
            this.Engine = Engine;
            this.Year = Year;
            this.HP = HP;
        }
    }


    //Static member to adjust HP depending on tuning stage selected
    public static class AdjustHorsepower
    {
        public static double IncreaseHorsepower(Car Vehicle, int Stage)
        {
            switch (Stage)
            {
                case 2:
                    return Vehicle.HP = Math.Round(Vehicle.HP * 1.25);
                case 1:
                    return Vehicle.HP = Math.Round(Vehicle.HP * 1.17);
                default:
                    return Vehicle.HP;
            }
        }
    }
}
