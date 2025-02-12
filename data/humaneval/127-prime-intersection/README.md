
# 127 -- Determine if intersection length is prime

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
        /// You are given two intervals,
        /// where each interval is a pair of integers. For example, interval = (start, end) = (1, 2).
        /// The given intervals are closed which means that the interval (start, end)
        /// includes both start and end.
        /// For each given interval, it is assumed that its start is less or equal its end.
        /// Your task is to determine whether the length of Intersection of these two 
        /// intervals is a prime number.
        /// Example, the Intersection of the intervals (1, 3), (2, 4) is (2, 3)
        /// which its length is 1, which not a prime number.
        /// If the length of the Intersection is a prime number, return "YES",
        /// otherwise, return "NO".
        /// If the two intervals don't intersect, return "NO".
        /// 
        /// 
        /// [input/output] samples:
        /// Intersection((1, 2), (2, 3)) ==> "NO"
        /// Intersection((-1, 1), (0, 4)) ==> "NO"
        /// Intersection((-3, -1), (-5, 5)) ==> "YES"
        /// 
        /// </summary>
        public static string Intersection (List<int> interval1, List<int> interval2) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Intersection(new List<int> {1,2},new List<int> {2,3});
            var expected1 = "NO";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Intersection(new List<int> {-1,1},new List<int> {0,4});
            var expected2 = "NO";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Intersection(new List<int> {-3,-1},new List<int> {-5,5});
            var expected3 = "YES";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = Intersection(new List<int> {-2,2},new List<int> {-4,0});
            var expected4 = "YES";
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = Intersection(new List<int> {-11,2},new List<int> {-1,-1});
            var expected5 = "NO";
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = Intersection(new List<int> {1,2},new List<int> {3,5});
            var expected6 = "NO";
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = Intersection(new List<int> {1,2},new List<int> {1,2});
            var expected7 = "NO";
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = Intersection(new List<int> {-2,-2},new List<int> {-3,-2});
            var expected8 = "NO";
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

        }
    }
}
```
