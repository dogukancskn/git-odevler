using System;

namespace Odev4_BildirimKanallari.Contracts;

public interface IMessageTemplate
{
    string Create(string title, string body);
}
