# 139 -- Brazilian factorial multiplies descending factorials

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
        /// The Brazilian factorial is defined as:
        /// brazilian_factorial(n) = n! * (n-1)! * (n-2)! * ... * 1!
        /// where n > 0
        /// 
        /// For example:
        /// >>> SpecialFactorial(4)
        /// 288
        /// 
        /// The function will receive an integer as input and should return the special
        /// factorial of this integer.
        /// 
        /// </summary>
        public static int SpecialFactorial (int n) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = SpecialFactorial(4);
            var expected1 = 288;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = SpecialFactorial(5);
            var expected2 = 34560;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = SpecialFactorial(7);
            var expected3 = 125411328000;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = SpecialFactorial(1);
            var expected4 = 1;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

        }
    }
}
```
