using GG_LabOps_Domain.Interfaces;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace GG_LabOps_Infrastructure.Messages
{
    public class RabbitMqService : IMessageNotificationService
    {
        private readonly IModel _channel;
        private const string _exchange = "notification-service";

        public RabbitMqService()
        {
        }

        public void Publish(object data, string routingKey)
        {
            var type = data.GetType();
            var payload = JsonConvert.SerializeObject(data);
            var byteArray = Encoding.UTF8.GetBytes(payload);

            Console.WriteLine($"{type.Name} Published");
            _channel.BasicPublish(_exchange, routingKey, null, byteArray);
        }
    }
}
