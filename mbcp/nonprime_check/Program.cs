using System;
using System.Diagnostics;

bool IsNotPrime(int n)
{
    bool result = false;
    for (int i = 2; i <= (int)Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            result = true;
        }
    }
    return result;
}

bool test1 = IsNotPrime(2);
Console.WriteLine($"Result: {test1}, Expected: {false}, Test Passed: {test1 == false}");
Debug.Assert(test1 == false);

bool test2 = IsNotPrime(10);
Console.WriteLine($"Result: {test2}, Expected: {true}, Test Passed: {test2 == true}");
Debug.Assert(test2 == true);

bool test3 = IsNotPrime(35);
Console.WriteLine($"Result: {test3}, Expected: {true}, Test Passed: {test3 == true}");
Debug.Assert(test3 == true);
