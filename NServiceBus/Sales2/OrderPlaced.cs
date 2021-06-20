using NServiceBus;

namespace Sales2
{
    public class OrderPlaced :
          IEvent
    {
        public string OrderId { get; set; }
    }
}
