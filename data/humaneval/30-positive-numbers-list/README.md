
# 30 -- Returns only positive numbers from a given list

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
        /// Return only positive numbers in the list.
        /// >>> GetPositive([-1, 2, -4, 5, 6])
        /// [2, 5, 6]
        /// >>> GetPositive([5, 3, -5, 2, -3, 3, 9, 0, 123, 1, -10])
        /// [5, 3, 2, 3, 9, 123, 1]
        /// 
        /// </summary>
        public static List<int> GetPositive (List<int> l) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = GetPositive(new List<int> {-1,-2,4,5,6});
            var expected1 = new List<int> {4,5,6};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = GetPositive(new List<int> {5,3,-5,2,3,3,9,0,123,1,-10});
            var expected2 = new List<int> {5,3,2,3,3,9,123,1};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = GetPositive(new List<int> {-1,-2});
            var expected3 = new List<int> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = GetPositive(new List<int> {});
            var expected4 = new List<int> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

        }
    }
}
```
