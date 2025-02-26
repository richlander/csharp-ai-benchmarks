# 58 -- Find sorted common elements in lists

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
        /// Return sorted unique Common elements for two lists.
        /// >>> Common([1, 4, 3, 34, 653, 2, 5], [5, 7, 1, 5, 9, 653, 121])
        /// [1, 5, 653]
        /// >>> Common([5, 3, 2, 8], [3, 2])
        /// [2, 3]
        /// 
        /// 
        /// </summary>
        public static List<int> Common (List<int> l1, List<int> l2) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Common(new List<int> {1,4,3,34,653,2,5},new List<int> {5,7,1,5,9,653,121});
            var expected1 = new List<int> {1,5,653};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Common(new List<int> {5,3,2,8},new List<int> {3,2});
            var expected2 = new List<int> {2,3};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Common(new List<int> {4,3,2,8},new List<int> {3,2,4});
            var expected3 = new List<int> {2,3,4};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = Common(new List<int> {4,3,2,8},new List<int> {});
            var expected4 = new List<int> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

        }
    }
}
```
