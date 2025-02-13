# 63 -- FibFib sequence: fib(n) = fib(n-1)+fib(n-2)+fib(n-3)

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
        /// The FibFib number sequence is a sequence similar to the Fibbonacci sequnece that's defined as follows:
        /// Fibfib(0) == 0
        /// Fibfib(1) == 0
        /// Fibfib(2) == 1
        /// Fibfib(n) == Fibfib(n-1) + Fibfib(n-2) + Fibfib(n-3).
        /// Please write a function to efficiently compute the n-th element of the Fibfib number sequence.
        /// >>> Fibfib(1)
        /// 0
        /// >>> Fibfib(5)
        /// 4
        /// >>> Fibfib(8)
        /// 24
        /// 
        /// </summary>
        public static int Fibfib (int n) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Fibfib(2);
            var expected1 = 1;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Fibfib(1);
            var expected2 = 0;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Fibfib(5);
            var expected3 = 4;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = Fibfib(8);
            var expected4 = 24;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = Fibfib(10);
            var expected5 = 81;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = Fibfib(12);
            var expected6 = 274;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = Fibfib(14);
            var expected7 = 927;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

        }
    }
}
```
