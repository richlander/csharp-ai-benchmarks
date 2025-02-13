# 90 -- Return 2nd smallest integer or None

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
        /// You are given a list of integers.
        /// Write a function NextSmallest() that returns the 2nd smallest element of the list.
        /// Return None if there is no such element.
        /// 
        /// NextSmallest([1, 2, 3, 4, 5]) == 2
        /// NextSmallest([5, 1, 4, 3, 2]) == 2
        /// NextSmallest([]) == None
        /// NextSmallest([1, 1]) == None
        /// 
        /// </summary>
        public static object NextSmallest (List<int> lst) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = NextSmallest(new List<int> {1,2,3,4,5});
            var expected1 = 2;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = NextSmallest(new List<int> {5,1,4,3,2});
            var expected2 = 2;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = NextSmallest(new List<int> {});
            var expected3 = null;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = NextSmallest(new List<int> {1,1});
            var expected4 = null;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = NextSmallest(new List<int> {1,1,1,1,0});
            var expected5 = 1;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = NextSmallest(new List<int> {1,1});
            var expected6 = null;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = NextSmallest(new List<int> {-35,34,12,-45});
            var expected7 = -35;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

        }
    }
}
```
