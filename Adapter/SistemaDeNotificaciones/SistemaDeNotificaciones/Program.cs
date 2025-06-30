using SistemaDeNotificaciones;

public class Program
{
    public static void Main (string[] args)
    {
        INotificationService notifier = new CloudPushNotificationAdapter();
        bool sent = notifier.SendNotification("Joel", "Alerta", "Tu pedido esta listo", NotificationPriority.High);
        var statuses = notifier.GetDeliveryStatus("Joel");
    }
}
