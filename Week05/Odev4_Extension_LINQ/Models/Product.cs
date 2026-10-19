using System;

namespace Odev4_Extension_LINQ.Models;

public class Product
{
    public int Id { get; }
    public string? Name { get; }
    public decimal Price { get; }
    public int Stock { get; }
    public Product(int ıd, string? name, decimal price, int stock)
    {
        Id = ıd;
        Name = name;
        Price = price;
        Stock = stock;
    }



}
