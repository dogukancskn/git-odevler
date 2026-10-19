using System;
using Odev3_Delegate.Contracts;

namespace Odev3_Delegate.Services;

public class Calculator
{
    public static int Execute(NumberOperation operation, int left, int right)
    {
        return operation(left,right);
    }
}
