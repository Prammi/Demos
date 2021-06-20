using NServiceBus;

namespace Sales2
{
    public class PlaceOrder :
         ICommand
    {
        public string OrderId { get; set; }
    }
}