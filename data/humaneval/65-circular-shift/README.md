
# 65 -- Circularly shift digits of x, reverse if shift is large

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
        /// Circular shift the digits of the integer x, shift the digits right by shift
        /// and return the result as a string.
        /// If shift > number of digits, return digits reversed.
        /// >>> CircularShift(12, 1)
        /// "21"
        /// >>> CircularShift(12, 2)
        /// "12"
        /// 
        /// </summary>
        public static string CircularShift (int x, int shift) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = CircularShift(100,2);
            var expected1 = "001";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = CircularShift(12,2);
            var expected2 = "12";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = CircularShift(97,8);
            var expected3 = "79";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = CircularShift(12,1);
            var expected4 = "21";
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = CircularShift(11,101);
            var expected5 = "11";
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

        }
    }
}
```
