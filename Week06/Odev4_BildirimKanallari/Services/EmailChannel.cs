using System;
using Odev4_BildirimKanallari.Contracts;

namespace Odev4_BildirimKanallari.Services;

public class EmailChannel : INotificationChannel
{
    public void Send(string recipient, string message)
    {
        Console.WriteLine($"EMAİL-> {recipient} {message}");
    }
}
