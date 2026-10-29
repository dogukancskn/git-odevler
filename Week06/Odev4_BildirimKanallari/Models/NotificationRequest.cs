using System;

namespace Odev4_BildirimKanallari.Models;

public record NotificationRequest(
    string Recipient,
    string Title,
    string Body
);

