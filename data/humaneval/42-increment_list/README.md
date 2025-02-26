# 42 -- Increment each list element by 1

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
        /// Return list with elements incremented by 1.
        /// >>> IncrList([1, 2, 3])
        /// [2, 3, 4]
        /// >>> IncrList([5, 3, 5, 2, 3, 3, 9, 0, 123])
        /// [6, 4, 6, 3, 4, 4, 10, 1, 124]
        /// 
        /// </summary>
        public static List<int> IncrList (List<int> l) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = IncrList(new List<int> {});
            var expected1 = new List<int> {};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = IncrList(new List<int> {3,2,1});
            var expected2 = new List<int> {4,3,2};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = IncrList(new List<int> {5,2,5,2,3,3,9,0,123});
            var expected3 = new List<int> {6,3,6,3,4,4,10,1,124};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

        }
    }
}
```
