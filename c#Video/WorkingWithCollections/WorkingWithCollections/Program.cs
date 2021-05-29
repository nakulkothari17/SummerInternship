using System;
using System.Collections;
using System.Collections.Generic;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car1 = new Car();
            //car1.VIN = "1028";
            //car1.Make = "Nissan";
            //car1.Model = "Micra";

            //Car car2 = new Car();
            //car2.VIN = "4543";
            //car2.Make = "Honda";
            //car2.Model = "Jazz";

            //Book b1 = new Book();
            //b1.Author = "Raftaar";
            //b1.Title = "Mantoniyaat";
            //b1.ISBN = "0-000-00000-0";
            
            //arraylist are dynamically sized
            //cool features like sort remove etc
            /*
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            */

            //List<T>

            
            //List<Car> myList = new List<Car>();
            //myList.Add(car1);
            //myList.Add(car2);
            ////myList.Add(b1);

            //foreach (Car car in myList )
            //{
            //    Console.WriteLine(" {0}, {1} \n",car.Make , car.Model);
            //}
            

            //Dictionary<Tkey,Tvalue> 

            //Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();

            //myDictionary.Add(car1.VIN, car1);
            //myDictionary.Add(car2.VIN, car2);

            //Console.WriteLine(myDictionary["4548"].Make);

            //string[] names = { "Nakul", "vatsal", "Alkesh", "Anurag" };

            //OBJ Initializer no constructor needed
            //Car car1 = new Car() { Make = "BMW", Model = "Jetta", VIN = "A1"}
            //Car car2 = new Car() { Make = "Audi", Model = "Betta", VIN = "B1" }

            //Collection Initlizer
            List<Car> myList = new List<Car>() {
                new Car { Make = "Nissan", Model = "Micra", VIN = "1028"},
                new Car { Make = "Honda", Model = "Jazz", VIN = "4543"}
            };

            foreach (Car car in myList)
            {
                Console.WriteLine(car);
            }
             

            Console.ReadLine();
        }
    }
    
    class Car
    { 
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    { 
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
    
}
