using System;
using Odev2_Constraint_Polymorphism.Contracts;

namespace Odev2_Constraint_Polymorphism.Services;

public class ItemPrinter
{

    public static void PrintDescriptions<T>(List<T> items) where T : IDescribable
    {
        foreach (T item in items)
        {
            Console.WriteLine(item.Describe());
        }
        // where kısıtı olmazsa derleyici T tipinin Describe()
        // metoduna sahip olduğunu bilemez ve kod derlenmez.
    }
    public static void PrintIds<T>(List<T> items) where T : IIdentifiable
    {
        foreach (T item in items)
        {
            Console.WriteLine(item.Id);
        }
    }
}
