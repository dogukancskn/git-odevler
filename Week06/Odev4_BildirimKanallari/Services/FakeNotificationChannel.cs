using System;
using Odev4_BildirimKanallari.Contracts;

namespace Odev4_BildirimKanallari.Services;

public class FakeNotificationChannel : INotificationChannel
{
    public string? LastRecipient { get; set; }
    public string? LastMessage { get; set; }

    public void Send(string recipient, string message)
    {
        LastRecipient = recipient;
        LastMessage = message;
    }
}
