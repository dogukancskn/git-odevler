using System;

namespace Odev7_Interface.Models;

public interface IIdentifiable
{
    public int Id { get; set; } 

    string GetDisplayName();
}
