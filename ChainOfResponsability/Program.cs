using ChainOfResponsability.Middlewars;
using ChainOfResponsability.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    internal class Program
    {
        private static Server server;   
        static void Init()
        {
            // Initialize the server instance
            server = new Server();
            // Register a user with email and password
            server.RegisterUser("geovane@teste.com", "teste123");

            // Register another user with username and password
            server.RegisterUser("teste", "teste123");

            // Create a middleware instance for user checking
            Middleware middleware = new CheckUserMiddleware(server);

            // user checking middleware with permission checking middleware
            middleware.LinkWith(new CheckPermissionMiddleware());

            server.SetMiddleware(middleware);
        }
        static void Main(string[] args)
        {

            Init();

            Boolean done;


            do
            {
                Console.WriteLine("Digite o email:");
                string email = Console.ReadLine();
                Console.WriteLine("Digite a senha:");
                string password = Console.ReadLine();
                done = server.LogIn(email, password);
            } while (!done);

            Console.ReadLine();
        }
    }
}
