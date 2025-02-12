
# 70 -- Sort list: min, max, repeat for strange order

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
        /// Given list of integers, return list in strange order.
        /// Strange sorting, is when you start with the minimum value,
        /// then maximum of the remaining integers, then minimum and so on.
        /// 
        /// Examples:
        /// StrangeSortList([1, 2, 3, 4]) == [1, 4, 2, 3]
        /// StrangeSortList([5, 5, 5, 5]) == [5, 5, 5, 5]
        /// StrangeSortList([]) == []
        /// 
        /// </summary>
        public static List<int> StrangeSortList (List<int> lst) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = StrangeSortList(new List<int> {1,2,3,4});
            var expected1 = new List<int> {1,4,2,3};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = StrangeSortList(new List<int> {5,6,7,8,9});
            var expected2 = new List<int> {5,9,6,8,7};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = StrangeSortList(new List<int> {1,2,3,4,5});
            var expected3 = new List<int> {1,5,2,4,3};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = StrangeSortList(new List<int> {5,6,7,8,9,1});
            var expected4 = new List<int> {1,9,5,8,6,7};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = StrangeSortList(new List<int> {5,5,5,5});
            var expected5 = new List<int> {5,5,5,5};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = StrangeSortList(new List<int> {});
            var expected6 = new List<int> {};
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = StrangeSortList(new List<int> {1,2,3,4,5,6,7,8});
            var expected7 = new List<int> {1,8,2,7,3,6,4,5};
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = StrangeSortList(new List<int> {0,2,2,2,5,5,-5,-5});
            var expected8 = new List<int> {-5,5,-5,5,0,2,2,2};
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = StrangeSortList(new List<int> {111111});
            var expected9 = new List<int> {111111};
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

        }
    }
}
```
