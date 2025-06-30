using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeNotificaciones
{
    public class CloudPushNotificationAdapter : INotificationService
    {
        private CloudPushService CloudoService;

        public CloudPushNotificationAdapter()
        {
            CloudoService = new CloudPushService();
        }

        private int MapPriorityToUrgencyLevel(NotificationPriority priority)
        {
            switch (priority)
            {
                case NotificationPriority.Low:
                    return 1;
                case NotificationPriority.Medium:
                    return 2;
                case NotificationPriority.High:
                    return 3;
                case NotificationPriority.Critical:
                    return 4;
                default:
                    return 2;
            }
        }


        public bool SendNotification(string userId, string title, string message, NotificationPriority priority)
        {
            int urgencyLevel = MapPriorityToUrgencyLevel(priority);

            var cloudMessage = new CloudMessage
            {
                Subject = title,
                Content = message,
                UrgencyLevel = urgencyLevel,
             };

            string messageId = CloudoService.PushMessage(userId, cloudMessage);

            return !string.IsNullOrEmpty(messageId);

        }
        private NotificationStatus MapDeliveryReport(DeliveryReport report)
        {
            return new NotificationStatus
            {
                Id = report.MessageId,           
                Delivered = report.WasDelivered, 
                Timestamp = report.DeliveredAt  
            };
        }

        public List<NotificationStatus> GetDeliveryStatus(string userId)
        {
            var deliveryReports = CloudoService.CheckDeliveries(userId);

            var result = deliveryReports.Select(MapDeliveryReport).ToList();
            return result;
        }
    }
}
