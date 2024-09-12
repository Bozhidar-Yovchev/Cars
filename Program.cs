using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double FuelQuantity = double.Parse(Console.ReadLine());
            double FuelConsumption = double.Parse(Console.ReadLine());


            Car firstCar = new Car();
            Console.WriteLine(firstCar);

            Car secondCar = new Car(make, model, year);
            Console.WriteLine(secondCar);

            Car thridCar = new Car(make, model, year, FuelQuantity, FuelConsumption);
            Console.WriteLine(thridCar);
        }
    }
}
