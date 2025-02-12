
# 88 -- Sort array based on sum of first and last values

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
        /// Given an array of non-negative integers, return a copy of the given array after sorting,
        /// you will sort the given array in ascending order if the sum( first index value, last index value) is odd,
        /// or sort it in descending order if the sum( first index value, last index value) is even.
        /// 
        /// Note:
        /// * don't change the given array.
        /// 
        /// Examples:
        /// * SortArray([]) => []
        /// * SortArray([5]) => [5]
        /// * SortArray([2, 4, 3, 0, 1, 5]) => [0, 1, 2, 3, 4, 5]
        /// * SortArray([2, 4, 3, 0, 1, 5, 6]) => [6, 5, 4, 3, 2, 1, 0]
        /// 
        /// </summary>
        public static List<int> SortArray (List<int> array) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = SortArray(new List<int> {});
            var expected1 = new List<int> {};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = SortArray(new List<int> {5});
            var expected2 = new List<int> {5};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = SortArray(new List<int> {2,4,3,0,1,5});
            var expected3 = new List<int> {0,1,2,3,4,5};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = SortArray(new List<int> {2,4,3,0,1,5,6});
            var expected4 = new List<int> {6,5,4,3,2,1,0};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = SortArray(new List<int> {2,1});
            var expected5 = new List<int> {1,2};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = SortArray(new List<int> {15,42,87,32,11,0});
            var expected6 = new List<int> {0,11,15,32,42,87};
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = SortArray(new List<int> {21,14,23,11});
            var expected7 = new List<int> {23,21,14,11};
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

        }
    }
}
```
