using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeNotificaciones
{
    public class CloudPushService
    {
        public string PushMessage(string recipient, CloudMessage msg)
        {
            // Simulacion de envío
            Console.WriteLine($"CloudPush: Enviando a {recipient} - {msg.Content}");
            return Guid.NewGuid().ToString(); // ID del mensaje
        }

        public List<DeliveryReport> CheckDeliveries(string recipient)
        {
            // Simulacion de consulta de estado
            return new List<DeliveryReport>
        {
            new DeliveryReport
            {
                MessageId = Guid.NewGuid().ToString(),
                WasDelivered = true,
                DeliveredAt = DateTime.Now.AddMinutes(-5)
            }
        };
        }
    }

    public class CloudMessage
    {
        public string Content { get; set; }
        public int UrgencyLevel { get; set; } // 1=Baja, 2=Media, 3=Alta, 4=Crítica
        public string Subject { get; set; }
    }

    public class DeliveryReport
    {
        public string MessageId { get; set; }
        public bool WasDelivered { get; set; }
        public DateTime DeliveredAt { get; set; }
    }
}
