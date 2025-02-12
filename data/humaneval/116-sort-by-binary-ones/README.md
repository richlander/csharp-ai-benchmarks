
# 116 -- Sort by binary ones, then by decimal value

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
        /// In this Kata, you have to sort an array of non-negative integers according to
        /// number of ones in their binary representation in ascending order.
        /// For similar number of ones, sort based on decimal value.
        /// 
        /// It must be implemented like this:
        /// >>> SortArray([1, 5, 2, 3, 4]) == [1, 2, 3, 4, 5]
        /// >>> SortArray([-2, -3, -4, -5, -6]) == [-6, -5, -4, -3, -2]
        /// >>> SortArray([1, 0, 2, 3, 4]) [0, 1, 2, 3, 4]
        /// 
        /// </summary>
        public static List<int> SortArray (List<int> arr) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = SortArray(new List<int> {1,5,2,3,4});
            var expected1 = new List<int> {1,2,4,3,5};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = SortArray(new List<int> {-2,-3,-4,-5,-6});
            var expected2 = new List<int> {-4,-2,-6,-5,-3};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = SortArray(new List<int> {1,0,2,3,4});
            var expected3 = new List<int> {0,1,2,4,3};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = SortArray(new List<int> {});
            var expected4 = new List<int> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = SortArray(new List<int> {2,5,77,4,5,3,5,7,2,3,4});
            var expected5 = new List<int> {2,2,4,4,3,3,5,5,5,7,77};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = SortArray(new List<int> {3,6,44,12,32,5});
            var expected6 = new List<int> {32,3,5,6,12,44};
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = SortArray(new List<int> {2,4,8,16,32});
            var expected7 = new List<int> {2,4,8,16,32};
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = SortArray(new List<int> {2,4,8,16,32});
            var expected8 = new List<int> {2,4,8,16,32};
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

        }
    }
}
```
