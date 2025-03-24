﻿using FactoryMetho.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMetho.Factories
{
    abstract class Transport
    {

        public void StartTransport()
        {
            IVehicle vehicle = CreateTransport();
            vehicle.StartRoute();
        }
        protected abstract IVehicle CreateTransport();
    }
}
