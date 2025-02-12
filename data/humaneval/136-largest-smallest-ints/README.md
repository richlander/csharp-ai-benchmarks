
# 136 -- Find the largest neg. and smallest pos. in a list

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
        /// Create a function that returns a tuple (a, b), where 'a' is
        /// the largest of negative integers, and 'b' is the smallest
        /// of positive integers in a list.
        /// If there is no negative or positive integers, return them as None.
        /// 
        /// Examples:
        /// LargestSmallestIntegers([2, 4, 1, 3, 5, 7]) == (None, 1)
        /// LargestSmallestIntegers([]) == (None, None)
        /// LargestSmallestIntegers([0]) == (None, None)
        /// 
        /// </summary>
        public static List<object> LargestSmallestIntegers (List<int> lst) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = LargestSmallestIntegers(new List<int> {2,4,1,3,5,7});
            var expected1 = new List<object> {null,1};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = LargestSmallestIntegers(new List<int> {2,4,1,3,5,7,0});
            var expected2 = new List<object> {null,1};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = LargestSmallestIntegers(new List<int> {1,3,2,4,5,6,-2});
            var expected3 = new List<object> {-2,1};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = LargestSmallestIntegers(new List<int> {4,5,3,6,2,7,-7});
            var expected4 = new List<object> {-7,2};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = LargestSmallestIntegers(new List<int> {7,3,8,4,9,2,5,-9});
            var expected5 = new List<object> {-9,2};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = LargestSmallestIntegers(new List<int> {});
            var expected6 = new List<object> {null,null};
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = LargestSmallestIntegers(new List<int> {0});
            var expected7 = new List<object> {null,null};
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = LargestSmallestIntegers(new List<int> {-1,-3,-5,-6});
            var expected8 = new List<object> {-1,null};
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = LargestSmallestIntegers(new List<int> {-1,-3,-5,-6,0});
            var expected9 = new List<object> {-1,null};
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

            var actual10 = LargestSmallestIntegers(new List<int> {-6,-4,-4,-3,1});
            var expected10 = new List<object> {-3,1};
            var result10 = compareLogic.Compare(actual10, expected10);
            if (!result10.AreEqual) {throw new Exception("Exception --- test case 9 failed to pass");}

            var actual11 = LargestSmallestIntegers(new List<int> {-6,-4,-4,-3,-100,1});
            var expected11 = new List<object> {-3,1};
            var result11 = compareLogic.Compare(actual11, expected11);
            if (!result11.AreEqual) {throw new Exception("Exception --- test case 10 failed to pass");}

        }
    }
}
```
