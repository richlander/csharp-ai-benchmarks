
# 33 -- Sort every third element in the list

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
        /// This function takes a list l and returns a list l' such that
        /// l' is identical to l in the indicies that are not divisible by three, while its values at the indicies that are divisible by three are equal
        /// to the values of the corresponding indicies of l, but sorted.
        /// >>> SortThird([1, 2, 3])
        /// [1, 2, 3]
        /// >>> SortThird([5, 6, 3, 4, 8, 9, 2])
        /// [2, 6, 3, 4, 8, 9, 5]
        /// 
        /// </summary>
        public static List<int> SortThird (List<int> l) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = SortThird(new List<int> {1,2,3});
            var expected1 = new List<int> {1,2,3};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = SortThird(new List<int> {5,3,-5,2,-3,3,9,0,123,1,-10});
            var expected2 = new List<int> {1,3,-5,2,-3,3,5,0,123,9,-10};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = SortThird(new List<int> {5,8,-12,4,23,2,3,11,12,-10});
            var expected3 = new List<int> {-10,8,-12,3,23,2,4,11,12,5};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = SortThird(new List<int> {5,6,3,4,8,9,2});
            var expected4 = new List<int> {2,6,3,4,8,9,5};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = SortThird(new List<int> {5,8,3,4,6,9,2});
            var expected5 = new List<int> {2,8,3,4,6,9,5};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = SortThird(new List<int> {5,6,9,4,8,3,2});
            var expected6 = new List<int> {2,6,9,4,8,3,5};
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = SortThird(new List<int> {5,6,3,4,8,9,2,1});
            var expected7 = new List<int> {2,6,3,4,8,9,5,1};
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

        }
    }
}
```
