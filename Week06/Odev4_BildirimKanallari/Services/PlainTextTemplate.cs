using System;
using Odev4_BildirimKanallari.Contracts;

namespace Odev4_BildirimKanallari.Services;

public class PlainTextTemplate : IMessageTemplate
{
    public string Create(string title, string body)
    {
       return $"{title} | {body}"; 
    }
}
