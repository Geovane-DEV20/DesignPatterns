using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Middlewars
{
     class CheckPermissionMiddleware : Middleware
    {

        public override bool Check(string email, string password)
        {
            if (email.Equals("geovane@teste.com.br")){
                Console.WriteLine("Usuário autorizado com sucesso!");
                return true;
            }

            Console.WriteLine("Seja bem vindo");

            return CheckNext(email, password);  

        }

    }
}
