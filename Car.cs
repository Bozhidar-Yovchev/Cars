using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }
        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public Car()
        {
            this.Make = "Subaru";
            this.Model = "Impreza";
            this.Year = 2005;
            this.fuelQuantity = 50;
            this.FuelConsumption = 10;
        }
        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car(string make, string model, int year, double FuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public override string ToString()
        {
            return $"Make: {this.Make}" + Environment.NewLine +
                $"Model:{this.Model}"+ Environment.NewLine +
                $"Year:{this.Year}" + Environment.NewLine +
                $"fuelQuantity{this.FuelQuantity}"+ Environment.NewLine +
               $"fuelConsumption{this.FuelConsumption}";
        }


    }
}
