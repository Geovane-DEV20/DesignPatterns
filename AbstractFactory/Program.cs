using AbstractFactory.App;
using AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractFactory
{
     class Program
    {
        static Application ConfigureApplication()
        {
            Application app;
            ITransportFactory transportFactory;
            string company = "uber";
            
            if (company == "uber")
            {
               transportFactory = new UberTransport();
            }
            else if(company == "lime")
            {
                transportFactory = new LimeTransport();
            }
            else
            {
                transportFactory = new NineNinetransport();
            }

            app = new Application(transportFactory);


            return app;

        }
        static void Main(string[] args)
        {
            Application app = ConfigureApplication();
            app.startRoute();
            Console.ReadLine();
        }
    }
}
