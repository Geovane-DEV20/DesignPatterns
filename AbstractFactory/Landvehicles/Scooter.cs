using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Landvehicles
{
    class Scooter : ILandvehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Patinete");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("iniciando trajeto de patinete");
        }
    }
}
