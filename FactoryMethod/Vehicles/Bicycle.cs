using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMetho.Vehicles
{
    class Bicycle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegando encomenda");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando a entrega dessa encomenda de bicicleta");
        }
    }
}
