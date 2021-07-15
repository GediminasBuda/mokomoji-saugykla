using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture11
{
    public class Car
    {
        protected string _idNumber;
        public string _brand;

        public Car(string idNumber, string brand)
        {
            _idNumber = idNumber;
            _brand = brand;
        }
        public override string ToString()
        {
            return $"{_idNumber} {_brand}";
        }
    }
    public class Dealership
    {
        private List<Car> dealership;//static negali buti naudojamas

        public Dealership()
        {
            dealership = new List<Car>();
        }

        public void AddCar(Car car)// cia parametro"car" tipas yra Car!!!!!!!
        {
            dealership.Add(car);
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Number of all cars: " + dealership.Count.ToString());//cia be "+" susdedame visa teksta i masyva ar lista;
            sb.AppendLine("First car in Dealership: " + dealership[0].ToString());
            sb.AppendLine("Last car in Dealership: " + dealership[dealership.Count - 1].ToString());
            foreach(var auto in dealership)
            {
                sb.AppendLine(auto.ToString());
            }
            return sb.ToString();
        }   

    }


}
