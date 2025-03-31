using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
     class Token
    {
        private string token = "Token_de_autenticação";

        public string GetToken()
        {
            return token;
        }   


    }
}
