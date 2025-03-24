using AbstractFactory.Aircrafts;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.Factories
{
    class NineNinetransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Helicopter();
        }
        public ILandvehicle CreateTransportVehicle()
        {
            return new Motorcycle();
        }   
    }
}
