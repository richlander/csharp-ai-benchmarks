# 59 -- Largest prime factor of n

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
        /// Return the largest prime factor of n. Assume n > 1 and is not a prime.
        /// >>> LargestPrimeFactor(13195)
        /// 29
        /// >>> LargestPrimeFactor(2048)
        /// 2
        /// 
        /// </summary>
        public static int LargestPrimeFactor (int n) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = LargestPrimeFactor(15);
            var expected1 = 5;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = LargestPrimeFactor(27);
            var expected2 = 3;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = LargestPrimeFactor(63);
            var expected3 = 7;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = LargestPrimeFactor(330);
            var expected4 = 11;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = LargestPrimeFactor(13195);
            var expected5 = 29;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

        }
    }
}
```
