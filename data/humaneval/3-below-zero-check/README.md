
# 3 -- Detect if balance falls below zero

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
        /// You're given a list of deposit and withdrawal operations on a bank account that starts with
        /// zero balance. Your task is to detect if at any point the balance of account fallls below zero, and
        /// at that point function should return True. Otherwise it should return False.
        /// >>> BelowZero([1, 2, 3])
        /// False
        /// >>> BelowZero([1, 2, -4, 5])
        /// True
        /// 
        /// </summary>
        public static bool BelowZero (List<int> operations) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = BelowZero(new List<int> {});
            var expected1 = false;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = BelowZero(new List<int> {1,2,-3,1,2,-3});
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = BelowZero(new List<int> {1,2,-4,5,6});
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = BelowZero(new List<int> {1,-1,2,-2,5,-5,4,-4});
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = BelowZero(new List<int> {1,-1,2,-2,5,-5,4,-5});
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = BelowZero(new List<int> {1,-2,2,-2,5,-5,4,-4});
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

        }
    }
}
```
