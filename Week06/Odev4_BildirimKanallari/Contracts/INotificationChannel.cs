using System;

namespace Odev4_BildirimKanallari.Contracts;

public interface INotificationChannel
{
    void Send(string recipient, string message);
    
}
