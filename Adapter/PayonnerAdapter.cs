using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class PayonnerAdapter : IPayPalPayment
    {
        private Payonner payonner;
        public PayonnerAdapter(Payonner payonner)
        {
            this.payonner = payonner;
            Console.WriteLine("Adaptando o Payonner usando o Adapter");
        }
        public Token AuthToken()
        {
            return this.payonner.AuthToken();
        }

        public void PaypalPayment()
        {
            this.payonner.SendPayment();
        }

        public void PaypalReceive()
        {
            this.payonner.ReceivePayment();
        }
    }
}
