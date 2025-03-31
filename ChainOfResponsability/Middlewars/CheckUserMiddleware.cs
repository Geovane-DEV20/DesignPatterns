using ChainOfResponsability.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Middlewars
{
     class CheckUserMiddleware : Middleware
    {
        private Server server;

        public CheckUserMiddleware(Server server)
        {
            this.server = server;
        }       
        public override bool Check(string email, string password)
        {
            if(!server.HasEmail(email))
            {
                Console.WriteLine("E-mail inválido");
                return false;
            }
            if(server.IsValidPassword(email, password))
            {
                Console.WriteLine("Email/Senha inválida");
                return false;
            }


            return CheckNext(email, password);  
        }
    }
}
