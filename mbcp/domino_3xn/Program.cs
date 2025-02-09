using System;
using System.Diagnostics;

int CountWays(int n)
{
    int[] A = new int[n + 1];
    int[] B = new int[n + 1];
    A[0] = 1;
    if(n >= 1)
    {
        A[1] = 0;
    }
    B[0] = 0;
    if(n >= 1)
    {
        B[1] = 1;
    }
    for (int i = 2; i <= n; i++)
    {
        A[i] = A[i - 2] + 2 * B[i - 1];
        B[i] = A[i - 1] + B[i - 2];
    }
    return A[n];
}

int result1 = CountWays(2);
Console.WriteLine($"Result: {result1}, Expected: 3, Test Passed: {result1 == 3}");
Debug.Assert(result1 == 3);

int result2 = CountWays(8);
Console.WriteLine($"Result: {result2}, Expected: 153, Test Passed: {result2 == 153}");
Debug.Assert(result2 == 153);

int result3 = CountWays(12);
Console.WriteLine($"Result: {result3}, Expected: 2131, Test Passed: {result3 == 2131}");
Debug.Assert(result3 == 2131);
