using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11
{ class Program {
    static void Main(string[] args)
    {
        var car1 = new Car("AZA111", "Tesla");
        var car2 = new Car("AZA555", "Fiat");
        var car3 = new Car("BBB555", "Bugatti");

        var dealership = new Dealership();

            dealership.AddCar(car1);
            dealership.AddCar(car2);
            dealership.AddCar(car3);
            Console.WriteLine(dealership.ToString());
    }
    }
}
