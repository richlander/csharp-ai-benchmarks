
# 13 -- Find GCD of two integers a, b; return result

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
        /// Return a greatest common divisor of two integers a and b
        /// >>> GreatestCommonDivisor(3, 5)
        /// 1
        /// >>> GreatestCommonDivisor(25, 15)
        /// 5
        /// 
        /// </summary>
        public static int GreatestCommonDivisor (int a, int b) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = GreatestCommonDivisor(3,7);
            var expected1 = 1;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = GreatestCommonDivisor(10,15);
            var expected2 = 5;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = GreatestCommonDivisor(49,14);
            var expected3 = 7;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = GreatestCommonDivisor(144,60);
            var expected4 = 12;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

        }
    }
}
```
