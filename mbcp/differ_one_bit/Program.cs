using System;
using System.Diagnostics;

bool IsPowerOfTwo(int x)
{
    return x != 0 && ((x & (x - 1)) == 0);
}

bool DifferAtOneBitPos(int a, int b)
{
    return IsPowerOfTwo(a ^ b);
}

var test1 = DifferAtOneBitPos(13, 9);
Console.WriteLine($"Result: {test1}, Expected: {true}, Test Passed: {test1 == true}");
Debug.Assert(test1 == true);

var test2 = DifferAtOneBitPos(15, 8);
Console.WriteLine($"Result: {test2}, Expected: {false}, Test Passed: {test2 == false}");
Debug.Assert(test2 == false);

var test3 = DifferAtOneBitPos(2, 4);
Console.WriteLine($"Result: {test3}, Expected: {false}, Test Passed: {test3 == false}");
Debug.Assert(test3 == false);
