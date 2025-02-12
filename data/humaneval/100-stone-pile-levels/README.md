
# 100 -- Create a list of stones per level for a pile

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
        /// Given a positive integer n, you have to make a pile of n levels of stones.
        /// The first level has n stones.
        /// The number of stones in the next level is:
        /// - the next odd number if n is odd.
        /// - the next even number if n is even.
        /// Return the number of stones in each level in a list, where element at index
        /// i represents the number of stones in the level (i+1).
        /// 
        /// Examples:
        /// >>> MakeAPile(3)
        /// [3, 5, 7]
        /// 
        /// </summary>
        public static List<int> MakeAPile (int n) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = MakeAPile(3);
            var expected1 = new List<int> {3,5,7};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = MakeAPile(4);
            var expected2 = new List<int> {4,6,8,10};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = MakeAPile(5);
            var expected3 = new List<int> {5,7,9,11,13};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = MakeAPile(6);
            var expected4 = new List<int> {6,8,10,12,14,16};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = MakeAPile(8);
            var expected5 = new List<int> {8,10,12,14,16,18,20,22};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

        }
    }
}
```
