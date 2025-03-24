using FactoryMetho.Factories;
using FactoryMetho.Vehicles;
using System;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Favor informar o tipo de veículo");
            Transport transport = null;
            if (args.Length > 0 && args[0] == "--uber")
            {

                transport  = new CarTransport();
                
            }
            else if (args.Length > 0 && args[0] == "--bike")
            {
                transport = new BicycleTransport();
            }
            else if (args.Length > 0 && args[0] == "--log")
            {
                 transport = new MotorcycleTransport();
            }
            else
            {
                Console.WriteLine("Selecione o tipo de serviço");
            }

            if(transport != null)
            {
                transport.StartTransport();
            }
            Console.ReadLine();
        }
    }
}
