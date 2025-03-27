
namespace Adapter
{
    interface IPayPalPayment
    {

        Token AuthToken();

        void PaypalPayment();

        void PaypalReceive();
    }
}
