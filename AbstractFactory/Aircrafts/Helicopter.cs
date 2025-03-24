using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
     class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos");
        }


        public void GetCargo()
        {
            Console.WriteLine("Passageiros a bordo");
        }


        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem");
        }
    }
}
