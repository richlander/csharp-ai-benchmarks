
# 146 -- Count numbers >10 with odd first & last digits

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
        /// Write a function that takes an array of numbers as input and returns 
        /// the number of elements in the array that are greater than 10 and both 
        /// first and last digits of a number are odd (1, 3, 5, 7, 9).
        /// For example:
        /// SpecialFilter([15, -73, 14, -15]) => 1 
        /// SpecialFilter([33, -2, -3, 45, 21, 109]) => 2
        /// 
        /// </summary>
        public static int SpecialFilter (List<int> nums) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = SpecialFilter(new List<int> {5,-2,1,-5});
            var expected1 = 0;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = SpecialFilter(new List<int> {15,-73,14,-15});
            var expected2 = 1;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = SpecialFilter(new List<int> {33,-2,-3,45,21,109});
            var expected3 = 2;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = SpecialFilter(new List<int> {43,-12,93,125,121,109});
            var expected4 = 4;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = SpecialFilter(new List<int> {71,-2,-33,75,21,19});
            var expected5 = 3;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = SpecialFilter(new List<int> {1});
            var expected6 = 0;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = SpecialFilter(new List<int> {});
            var expected7 = 0;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

        }
    }
}
```
