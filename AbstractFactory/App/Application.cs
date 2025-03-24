using AbstractFactory.Aircrafts;
using AbstractFactory.Factories;
using AbstractFactory.Landvehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.App
{
     class Application
    {

        private IAircraft aircraft;

        private ILandvehicle vehicle;

        public Application(ITransportFactory factory) {

            aircraft = factory.CreateTransportAircraft();
            vehicle = factory.CreateTransportVehicle();
        }
        public void startRoute()
        {
            vehicle.StartRoute();
            aircraft.StartRoute();  
        }
    }
}
