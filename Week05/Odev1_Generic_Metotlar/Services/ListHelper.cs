using System;

namespace Odev1_Generic_Metotlar.Services;

public class ListHelper
{
    public static T GetLast<T>(List<T> items)
    {
        return items[items.Count - 1];
    }

    public static int CountItems<T>(List<T> items)
    {
        return items.Count;
    }

    public static List<T> Reverse<T>(List<T> items)
    {
        List<T> reverseList = new();
        for (int i = items.Count-1; i >= 0; i--)
        {
            reverseList.Add(items[i]);
        }
        return reverseList;
    }
}
