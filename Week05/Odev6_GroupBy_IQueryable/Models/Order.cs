using System;

namespace Odev6_GroupBy_IQueryable.Models;

public class Order
{
    public int Id { get; set; }

    public string CustomerName { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public decimal Amount { get; set; }

    public string OrderDate { get; set; }= string.Empty;
}
