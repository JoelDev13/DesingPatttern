using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeNotificaciones
{
    public interface INotificationService
    {
        bool SendNotification(string userId, string title, string message, NotificationPriority priority);
        List<NotificationStatus> GetDeliveryStatus(string userId);
    }

    public enum NotificationPriority { Low, Medium, High, Critical }
    public class NotificationStatus
    {
        public string Id { get; set; }
        public bool Delivered { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
