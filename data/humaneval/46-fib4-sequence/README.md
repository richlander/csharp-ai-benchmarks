
# 46 -- Fib4: Fibonacci-like sequence with no recursion

## Prompt

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using KellermanSoftware.CompareNetObjects;

namespace Solution
{
    public class Program
    {
        /// <summary> 
        /// You're an expert C# programmer
        /// The Fib4 number sequence is a sequence similar to the Fibbonacci sequnece that's defined as follows:
        /// Fib4(0) -> 0
        /// Fib4(1) -> 0
        /// Fib4(2) -> 2
        /// Fib4(3) -> 0
        /// Fib4(n) -> Fib4(n-1) + Fib4(n-2) + Fib4(n-3) + Fib4(n-4).
        /// Please write a function to efficiently compute the n-th element of the Fib4 number sequence.  Do not use recursion.
        /// >>> Fib4(5)
        /// 4
        /// >>> Fib4(6)
        /// 8
        /// >>> Fib4(7)
        /// 14
        /// 
        /// </summary>
        public static int Fib4 (int n) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Fib4(5);
            var expected1 = 4;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Fib4(8);
            var expected2 = 28;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Fib4(10);
            var expected3 = 104;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = Fib4(12);
            var expected4 = 386;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

        }
    }
}
```
