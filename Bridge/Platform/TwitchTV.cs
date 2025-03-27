using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Platform
{
    internal class TwitchTV : IPlatform
    {
        public TwitchTV()
        {
            ConfigureRMTP();
            Console.WriteLine("TwitchTV: transmissão iniciada");
        }
        public void AuthToken()
        {
            Console.WriteLine("TwitchTV autorizando aplicação");
        }
        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("TwitchTV: configurando servidor RMTP");
        }
    }
    
    
}
