using System;

namespace Odev9_Record.Models;

public class MutableMember
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Plan { get; set; } = string.Empty;
    public decimal Price { get; set; }
}
