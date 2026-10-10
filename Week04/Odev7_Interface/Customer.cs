using System;
using Odev7_Interface.Models;

namespace Odev7_Interface;

public class Customer : IIdentifiable
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public string GetDisplayName()
    {
        return $"Müşteri [{Id}]: {Name}";
    }
}
