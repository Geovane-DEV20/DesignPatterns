using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class PayPal : IPayPalPayment
    {

        private Token token;    
        public Token AuthToken()
        {
            return new Token(); 
        }

        public void PaypalPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamentos com Paypal");
        }

        public void PaypalReceive()
        {
            Console.WriteLine("Recebendo pagamento com paypal");
        }
    }
}
