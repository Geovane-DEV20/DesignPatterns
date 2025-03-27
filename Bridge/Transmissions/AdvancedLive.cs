using Bridge.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Transmissions
{
     class AdvancedLive : Live
    {
        public AdvancedLive(IPlatform platform) : base(platform)
        {
        }   
        public void Subtitles()
        {
            Console.WriteLine("Legendas ativadas na transmissão.");
        }   

        public void Comments()
        {
            Console.WriteLine("Comentários liberados na `live.");
        }   
    }
}
