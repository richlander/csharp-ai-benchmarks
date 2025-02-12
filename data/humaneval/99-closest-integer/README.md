
# 99 -- Create a function to round numbers away from zero

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
        /// 
        /// Create a function that takes a value (string) representing a number
        /// and returns the closest integer to it. If the number is equidistant
        /// from two integers, round it away from zero.
        /// 
        /// Examples
        /// >>> ClosestInteger("10")
        /// 10
        /// >>> ClosestInteger("15.3")
        /// 15
        /// 
        /// Note:
        /// Rounding away from zero means that if the given number is equidistant
        /// from two integers, the one you should return is the one that is the
        /// farthest from zero. For example ClosestInteger("14.5") should
        /// return 15 and ClosestInteger("-14.5") should return -15.
        /// 
        /// </summary>
        public static int ClosestInteger (string value) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = ClosestInteger("10");
            var expected1 = 10;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = ClosestInteger("14.5");
            var expected2 = 15;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = ClosestInteger("-15.5");
            var expected3 = -16;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = ClosestInteger("15.3");
            var expected4 = 15;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = ClosestInteger("0");
            var expected5 = 0;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

        }
    }
}
```
