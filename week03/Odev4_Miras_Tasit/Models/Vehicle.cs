using System;

namespace Odev4_Miras_Tasit.Models;

public class Vehicle
{
    public int Id { get; set; }
    public string Brand { get; set; }=string.Empty;

    public virtual void Display()
    {
        Console.Write($"[{Id}] {Brand} ");
    }

}
