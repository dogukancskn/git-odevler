using System;

namespace Odev7_Async_WhenAll.Services;

public class DataLoader
{
    public async Task<string> LoadUserNameAsync(string Name)
    {
        await Task.Delay(800);
        return Name;
    }

    public async Task<int> LoadOrderCountAsync(int number)
    {
        await Task.Delay(1200);
        return number;
    }

    public async Task<decimal> LoadBalanceAsync(decimal balance)
    {
        await Task.Delay(1000);
        return balance;
    }
}
