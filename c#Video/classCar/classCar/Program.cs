using System;

namespace classCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Honda";
            myCar.Model = "Jazz";
            myCar.Year = 2012;
            myCar.Color = "White";

            Console.WriteLine("{0}, {1}, {2}, {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            Console.WriteLine("{0}",MarketValue(myCar)
                );

            Console.ReadLine();
        }

        private static int MarketValue(Car car)
        { 
            int CarValue = 100;

            return CarValue;
        }
    }

    class Car
    { 
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
}
