# 2 -- Find the decimal part of a number

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
        /// Given a positive floating point number, it can be decomposed into
        /// and integer part (largest integer smaller than given number) and decimals
        /// (leftover part always smaller than 1).
        /// 
        /// Return the decimal part of the number.
        /// >>> TruncateNumber(3.5)
        /// 0.5
        /// 
        /// </summary>
        public static double TruncateNumber (double number) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = TruncateNumber(3.5);
            var expected1 = 0.5;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = TruncateNumber(1.33);
            var expected2 = 0.33000000000000007;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = TruncateNumber(123.456);
            var expected3 = 0.45600000000000307;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

        }
    }
}
```
