using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos");
        }

        public void GetCargo()
        {
            Console.WriteLine("DRONE VOANDO");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem");
        }
    }
}
