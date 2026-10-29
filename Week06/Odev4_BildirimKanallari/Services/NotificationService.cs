using System;
using Odev4_BildirimKanallari.Contracts;
using Odev4_BildirimKanallari.Models;

namespace Odev4_BildirimKanallari.Services;

public class NotificationService
{
    private readonly INotificationChannel _NotificationChannel;
    private readonly IMessageTemplate _MessageTemplate;

    public NotificationService(
        INotificationChannel notificationChannel,
        IMessageTemplate messageTemplate
    )
    {
        _NotificationChannel = notificationChannel;
        _MessageTemplate = messageTemplate;
    }

    public void Send(NotificationRequest notificationRequest)
    {
        string message = _MessageTemplate.Create(
          notificationRequest.Title,
          notificationRequest.Body
         );

        _NotificationChannel.Send(
            notificationRequest.Recipient,
            message
         );
    }

}
