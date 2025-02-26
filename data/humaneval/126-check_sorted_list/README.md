# 126 -- Check if list is sorted; no >1 duplicates

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
        /// Given a list of numbers, return whether or not they are sorted
        /// in ascending order. If list has more than 1 duplicate of the same
        /// number, return False. Assume no negative numbers and only integers.
        /// 
        /// Examples
        /// IsSorted([5]) ➞ True
        /// IsSorted([1, 2, 3, 4, 5]) ➞ True
        /// IsSorted([1, 3, 2, 4, 5]) ➞ False
        /// IsSorted([1, 2, 3, 4, 5, 6]) ➞ True
        /// IsSorted([1, 2, 3, 4, 5, 6, 7]) ➞ True
        /// IsSorted([1, 3, 2, 4, 5, 6, 7]) ➞ False
        /// IsSorted([1, 2, 2, 3, 3, 4]) ➞ True
        /// IsSorted([1, 2, 2, 2, 3, 4]) ➞ False
        /// 
        /// </summary>
        public static bool IsSorted (List<int> lst) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = IsSorted(new List<int> {5});
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = IsSorted(new List<int> {1,2,3,4,5});
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = IsSorted(new List<int> {1,3,2,4,5});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = IsSorted(new List<int> {1,2,3,4,5,6});
            var expected4 = true;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = IsSorted(new List<int> {1,2,3,4,5,6,7});
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = IsSorted(new List<int> {1,3,2,4,5,6,7});
            var expected6 = false;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = IsSorted(new List<int> {});
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = IsSorted(new List<int> {1});
            var expected8 = true;
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = IsSorted(new List<int> {3,2,1});
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

            var actual10 = IsSorted(new List<int> {1,2,2,2,3,4});
            var expected10 = false;
            var result10 = compareLogic.Compare(actual10, expected10);
            if (!result10.AreEqual) {throw new Exception("Exception --- test case 9 failed to pass");}

            var actual11 = IsSorted(new List<int> {1,2,3,3,3,4});
            var expected11 = false;
            var result11 = compareLogic.Compare(actual11, expected11);
            if (!result11.AreEqual) {throw new Exception("Exception --- test case 10 failed to pass");}

            var actual12 = IsSorted(new List<int> {1,2,2,3,3,4});
            var expected12 = true;
            var result12 = compareLogic.Compare(actual12, expected12);
            if (!result12.AreEqual) {throw new Exception("Exception --- test case 11 failed to pass");}

            var actual13 = IsSorted(new List<int> {1,2,3,4});
            var expected13 = true;
            var result13 = compareLogic.Compare(actual13, expected13);
            if (!result13.AreEqual) {throw new Exception("Exception --- test case 12 failed to pass");}

        }
    }
}
```
