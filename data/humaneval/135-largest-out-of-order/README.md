
# 135 -- Find largest index where element is not in order

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
        /// Create a function which returns the largest index of an element which
        /// is not greater than or equal to the element immediately preceding it. If
        /// no such element exists then return -1. The given array will not contain
        /// duplicate values.
        /// 
        /// Examples:
        /// CanArrange([1,2,4,3,5]) = 3
        /// CanArrange([1,2,3]) = -1
        /// 
        /// </summary>
        public static int CanArrange (List<int> arr) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = CanArrange(new List<int> {1,2,4,3,5});
            var expected1 = 3;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = CanArrange(new List<int> {1,2,4,5});
            var expected2 = -1;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = CanArrange(new List<int> {1,4,2,5,6,7,8,9,10});
            var expected3 = 2;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = CanArrange(new List<int> {4,8,5,7,3});
            var expected4 = 4;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = CanArrange(new List<int> {});
            var expected5 = -1;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

        }
    }
}
```
