
# 151 -- Sum squares of odd non-negative integers

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
        /// Given a list of numbers, return the sum of squares of the numbers
        /// in the list that are odd. Ignore numbers that are negative or not integers.
        /// 
        /// DoubleTheDifference([1, 3, 2, 0]) == 1 + 9 + 0 + 0 = 10
        /// DoubleTheDifference([-1, -2, 0]) == 0
        /// DoubleTheDifference([9, -2]) == 81
        /// DoubleTheDifference([0]) == 0  
        /// 
        /// If the input list is empty, return 0.
        /// 
        /// </summary>
        public static int DoubleTheDifference (List<object> lst) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = DoubleTheDifference(new List<object> {});
            var expected1 = 0;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = DoubleTheDifference(new List<object> {5,4});
            var expected2 = 25;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = DoubleTheDifference(new List<object> {0.1,0.2,0.3});
            var expected3 = 0;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = DoubleTheDifference(new List<object> {-10,-20,-30});
            var expected4 = 0;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = DoubleTheDifference(new List<object> {-1,-2,8});
            var expected5 = 0;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = DoubleTheDifference(new List<object> {0.2,3,5});
            var expected6 = 34;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = DoubleTheDifference(new List<object> {-99,-97,-95,-93,-91,-89,-87,-85,-83,-81,-79,-77,-75,-73,-71,-69,-67,-65,-63,-61,-59,-57,-55,-53,-51,-49,-47,-45,-43,-41,-39,-37,-35,-33,-31,-29,-27,-25,-23,-21,-19,-17,-15,-13,-11,-9,-7,-5,-3,-1,1,3,5,7,9,11,13,15,17,19,21,23,25,27,29,31,33,35,37,39,41,43,45,47,49,51,53,55,57,59,61,63,65,67,69,71,73,75,77,79,81,83,85,87,89,91,93,95,97,99});
            var expected7 = 166650;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

        }
    }
}
```
