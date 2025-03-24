using FactoryMetho.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMetho.Factories
{
    class CarTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Car();
        }
    }
}
