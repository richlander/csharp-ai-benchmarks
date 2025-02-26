# 145 -- Sort list by digit sum, keep original order

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
        /// Write a function which sorts the given list of integers
        /// in ascending order according to the sum of their digits.
        /// Note: if there are several items with similar sum of their digits,
        /// order them based on their index in original list.
        /// 
        /// For example:
        /// >>> OrderByPoints([1, 11, -1, -11, -12]) == [-1, -11, 1, -12, 11]
        /// >>> OrderByPoints([]) == []
        /// 
        /// </summary>
        public static List<int> OrderByPoints (List<int> nums) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = OrderByPoints(new List<int> {1,11,-1,-11,-12});
            var expected1 = new List<int> {-1,-11,1,-12,11};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = OrderByPoints(new List<int> {1234,423,463,145,2,423,423,53,6,37,3457,3,56,0,46});
            var expected2 = new List<int> {0,2,3,6,53,423,423,423,1234,145,37,46,56,463,3457};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = OrderByPoints(new List<int> {});
            var expected3 = new List<int> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = OrderByPoints(new List<int> {1,-11,-32,43,54,-98,2,-3});
            var expected4 = new List<int> {-3,-32,-98,-11,1,2,43,54};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = OrderByPoints(new List<int> {1,2,3,4,5,6,7,8,9,10,11});
            var expected5 = new List<int> {1,10,2,11,3,4,5,6,7,8,9};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = OrderByPoints(new List<int> {0,6,6,-76,-21,23,4});
            var expected6 = new List<int> {-76,-21,0,4,23,6,6};
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

        }
    }
}
```
