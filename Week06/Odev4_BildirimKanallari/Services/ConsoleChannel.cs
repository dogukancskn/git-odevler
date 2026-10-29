using System;
using Odev4_BildirimKanallari.Contracts;

namespace Odev4_BildirimKanallari.Services;

public class ConsoleChannel : INotificationChannel
{
    public void Send(string recipient, string message)
    {
        Console.WriteLine($"KONSOL-> {recipient} {message}");
    }
}
