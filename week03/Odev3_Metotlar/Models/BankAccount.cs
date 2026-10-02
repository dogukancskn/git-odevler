using System;

namespace Odev3_Metotlar.Models;

public class BankAccount
{
    public string OwnerName { get; set; } = string.Empty;

    public decimal Balance { get; set; }

    public void Display()
    {
        Console.WriteLine($"Hesap Sahibi: {OwnerName} Bakiye: {Balance}");
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("UYARI! Tutar pozitif olmalı");
            return;
        }
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > Balance)
        {
            Console.WriteLine("UYARI! Yetersiz Bakiye");
            return;
        }
        Balance -= amount;
    }

    public string GetSummary()
    {
        return $"{OwnerName} -- {Balance} TL";
    }
}
