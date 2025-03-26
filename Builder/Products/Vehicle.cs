using Builder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Products
{
    class Vehicle
    {
        private VehicleType vehicleType;
        private int seats;
        private Engine engine;
        private Transmission transmission;

        public VehicleType VehicleType
        {
            get { return vehicleType; }
            set { vehicleType = value; }
        }

        public int Seats 
        {
            get { return seats; }
            set { seats = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public Transmission Transmission
        {
            get { return transmission; }
            set { transmission = value; }
        }
    }
}
