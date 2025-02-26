# 106 -- Function f returns list with factorials/sums

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
        /// Implement the Function F that takes n as a parameter,
        /// and returns a list oF size n, such that the value oF the element at index i is the Factorial oF i iF i is even
        /// or the sum oF numbers From 1 to i otherwise.
        /// i starts From 1.
        /// the Factorial oF i is the multiplication oF the numbers From 1 to i (1 * 2 * ... * i).
        /// Example:
        /// F(5) == [1, 2, 6, 24, 15]
        /// 
        /// </summary>
        public static List<int> F (int n) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = F(5);
            var expected1 = new List<int> {1,2,6,24,15};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = F(7);
            var expected2 = new List<int> {1,2,6,24,15,720,28};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = F(1);
            var expected3 = new List<int> {1};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = F(3);
            var expected4 = new List<int> {1,2,6};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

        }
    }
}
```
