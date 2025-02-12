
# 52 -- Check if list numbers are below threshold

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
        /// Return True if all numbers in the list l are below threshold t.
        /// >>> BelowThreshold([1, 2, 4, 10], 100)
        /// True
        /// >>> BelowThreshold([1, 20, 4, 10], 5)
        /// False
        /// 
        /// </summary>
        public static bool BelowThreshold (List<int> l, int t) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = BelowThreshold(new List<int> {1,2,4,10},100);
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = BelowThreshold(new List<int> {1,20,4,10},5);
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = BelowThreshold(new List<int> {1,20,4,10},21);
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = BelowThreshold(new List<int> {1,20,4,10},22);
            var expected4 = true;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = BelowThreshold(new List<int> {1,8,4,10},11);
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = BelowThreshold(new List<int> {1,8,4,10},10);
            var expected6 = false;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

        }
    }
}
```
