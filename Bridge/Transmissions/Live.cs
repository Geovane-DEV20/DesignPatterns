using Bridge.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Transmissions
{
    class Live : ITransmisson
    {
        protected IPlatform _platform;  
        public Live(IPlatform platform)
        {
            _platform = platform;
        }
        public void Broadcasting()
        {
            Console.WriteLine($"Iniciando a transmissão nan {_platform} ");
        }

        public void Result()
        {
            Console.WriteLine("ON AIR");
        }
    }
}