# 73 -- Minimum changes to make array palindromic

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
        /// Given an array arr of integers, find the minimum number of elements that
        /// need to be changed to make the array palindromic. A palindromic array is an array that
        /// is read the same backwards and forwards. In one change, you can change one element to any other element.
        /// 
        /// For example:
        /// SmallestChange([1,2,3,5,4,7,9,6]) == 4
        /// SmallestChange([1, 2, 3, 4, 3, 2, 2]) == 1
        /// SmallestChange([1, 2, 3, 2, 1]) == 0
        /// 
        /// </summary>
        public static int SmallestChange (List<int> arr) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = SmallestChange(new List<int> {1,2,3,5,4,7,9,6});
            var expected1 = 4;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = SmallestChange(new List<int> {1,2,3,4,3,2,2});
            var expected2 = 1;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = SmallestChange(new List<int> {1,4,2});
            var expected3 = 1;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = SmallestChange(new List<int> {1,4,4,2});
            var expected4 = 1;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = SmallestChange(new List<int> {1,2,3,2,1});
            var expected5 = 0;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = SmallestChange(new List<int> {3,1,1,3});
            var expected6 = 0;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = SmallestChange(new List<int> {1});
            var expected7 = 0;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = SmallestChange(new List<int> {0,1});
            var expected8 = 1;
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

        }
    }
}
```
