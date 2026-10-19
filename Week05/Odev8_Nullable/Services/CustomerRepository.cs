using System;
using Odev8_Nullable.Models;

namespace Odev8_Nullable.Services;

public class CustomerRepository
{
    public readonly List<Customer> customers =
        new List<Customer>
      {
         new Customer(1, "Ahmet", "ahmet@example.com",
            new DateTime(1998, 5, 12)),

        new Customer(2, "Ayşe", null,
            new DateTime(2000, 8, 20)),

        new Customer(3, "Mehmet", "mehmet@example.com",
            null),

        new Customer(4, "Zeynep", "zeynep@example.com",
            new DateTime(1997, 3, 15))
      };

    public  Customer? FindByName(string name)
    {
        return customers.FirstOrDefault(c => c.Name == name);
    }

}
