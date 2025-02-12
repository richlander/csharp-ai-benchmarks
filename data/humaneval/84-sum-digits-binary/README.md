
# 84 -- Sum digits of N, return as binary string

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
        /// Given a positive integer N, return the total sum of its digits in binary.
        /// 
        /// Example
        /// For N = 1000, the sum of digits will be 1 the output should be "1".
        /// For N = 150, the sum of digits will be 6 the output should be "110".
        /// For N = 147, the sum of digits will be 12 the output should be "1100".
        /// 
        /// Variables:
        /// @N integer
        /// Constraints: 0 ≤ N ≤ 10000.
        /// Output:
        /// a string of binary number
        /// 
        /// </summary>
        public static string Solve (int N) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Solve(1000);
            var expected1 = "1";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Solve(150);
            var expected2 = "110";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Solve(147);
            var expected3 = "1100";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = Solve(333);
            var expected4 = "1001";
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = Solve(963);
            var expected5 = "10010";
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

        }
    }
}
```
