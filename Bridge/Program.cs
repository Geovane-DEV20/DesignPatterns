using Bridge.Platform;
using Bridge.Transmissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Program
    {

        static void StartLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            Live live = new Live(platform);

            live.Broadcasting();
            live.Result();
        }

        static void StartLiveAdvanced(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            AdvancedLive live = new AdvancedLive(platform);

            live.Broadcasting();
            live.Result();
            live.Subtitles();    
            live.Comments();
        }
        static void Main(string[] args)
        {

            StartLive(new Youtube());
            StartLive(new Facebook());
            StartLive(new TwitchTV());
        
        
        }
    }
}
