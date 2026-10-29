using Odev4_BildirimKanallari.Models;
using Odev4_BildirimKanallari.Services;

namespace Odev4_BildirimKanallari;

class Program
{
    static void Main(string[] args)
    {
        NotificationRequest request = new(
            "Doğukan",
            "Hesap güvenliği",
            "Yeni giriş tespit edildi."
        );

        NotificationService consoleService = new(

            new ConsoleChannel(),
            new PlainTextTemplate()
        );
        consoleService.Send(request);

        NotificationService emailService = new(
            new EmailChannel(),
            new UpperCaseTemplate()
        );
        emailService.Send(request);

        FakeNotificationChannel fakeChannel = new();

        NotificationService fakeService = new(
            fakeChannel,
            new PlainTextTemplate()
        );

        bool recipientIsCorrect = fakeChannel.LastRecipient
            == "Doğukan";
        bool messageIsCorrect = fakeChannel.LastMessage
            == "Hesap güvenliği | Yeni giriş tespit edildi.";

        Console.WriteLine(
            $"Test kanalı alıcı kontrolü: {recipientIsCorrect}"
        );
        Console.WriteLine(
            $"Test kanalı mesaj kontrolü:  {messageIsCorrect}"
        );

        /*
        * NotificationService yalnızca bildirim akışını yönetmelidir.
          Birden fazla sorumluluk almak SOLID prensiplerine aykırıdır
        */
    }
}
