public interface INotificationChannel
{
    void SendNotification(string message);
}

public class EmailNotificationChannel : INotificationChannel
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Enviando notificação por e-mail: {message}");
    }
}

public class SMSNotificationChannel : INotificationChannel
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Enviando notificação por SMS: {message}");
    }
}

public class NotificationService
{
    private readonly INotificationChannel _notificationChannel;

    public NotificationService(INotificationChannel notificationChannel)
    {
        _notificationChannel = notificationChannel;
    }

    public void SendNotification(string message)
    {
        _notificationChannel.SendNotification(message);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        var emailNotificationChannel = new EmailNotificationChannel();
        var smsNotificationChannel = new SMSNotificationChannel();

        var emailService = new NotificationService(emailNotificationChannel);
        var smsService = new NotificationService(smsNotificationChannel);

        emailService.SendNotification("Nova atualização disponível!");
        smsService.SendNotification("Seu pedido foi enviado.");
    }
}