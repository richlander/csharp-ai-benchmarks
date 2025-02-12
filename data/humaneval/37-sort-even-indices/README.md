
# 37 -- Sort even indices, keep odd ones unchanged

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
        /// l' is identical to l in the odd indicies, while its values at the even indicies are equal
        /// to the values of the even indicies of l, but sorted.
        /// >>> SortEven([1, 2, 3])
        /// [1, 2, 3]
        /// >>> SortEven([5, 6, 3, 4])
        /// [3, 6, 5, 4]
        /// 
        /// </summary>
        public static List<int> SortEven (List<int> l) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = SortEven(new List<int> {1,2,3});
            var expected1 = new List<int> {1,2,3};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = SortEven(new List<int> {5,3,-5,2,-3,3,9,0,123,1,-10});
            var expected2 = new List<int> {-10,3,-5,2,-3,3,5,0,9,1,123};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = SortEven(new List<int> {5,8,-12,4,23,2,3,11,12,-10});
            var expected3 = new List<int> {-12,8,3,4,5,2,12,11,23,-10};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

        }
    }
}
```
