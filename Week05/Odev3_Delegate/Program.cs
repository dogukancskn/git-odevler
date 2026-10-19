using Odev3_Delegate.Contracts;
using Odev3_Delegate.Services;

namespace Odev3_Delegate;

class Program
{
    public static int Add(int left, int right)
    {
        return left + right;
    }

    public static int selectMax(int left, int right)//
    {
        int maxNumber = left;
        if (right > left)
        {
            maxNumber = right;
        }

        return maxNumber;
    }
    static void Main(string[] args)
    {
        NumberOperation operation = Add;
        Console.WriteLine($"Toplam: {Calculator.Execute(operation, 12, 10)}");

        NumberOperation subtraction = (left, right) => left - right;
        Console.WriteLine($"Fark: {Calculator.Execute(subtraction, 18, 36)}");

        NumberOperation multiplication = (left, right) => left * right;
        Console.WriteLine($"Fark: {Calculator.Execute(subtraction, 9, 5)}");

        NumberOperation maxNumber = selectMax;
        Console.WriteLine($"Bütük olan: {Calculator.Execute(selectMax, 19, 25)}");

        Func<int, int, decimal> calculateVat = (int sayi1, int sayi2) =>
        {
            return sayi1 + sayi2;
        };
        decimal totalPrice = calculateVat(100, 20);
        Console.WriteLine($"KDV dahil: {totalPrice:F2} TL");

        Action<int, int> multiply =
           (int left, int right) => Console.WriteLine($"Bilgi: {left * right}");
        multiply(12, 13);

        Predicate<int> isAdult = age => age >= 18;

        Console.WriteLine(isAdult(20));
        Console.WriteLine(isAdult(16)); 
    }
}
