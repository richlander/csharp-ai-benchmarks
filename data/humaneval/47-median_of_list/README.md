# 47 -- Return median of list elements

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
        /// Return Median of elements in the list l.
        /// >>> Median([3, 1, 2, 4, 5])
        /// 3
        /// >>> Median([-10, 4, 6, 1000, 10, 20])
        /// 15.0
        /// 
        /// </summary>
        public static object Median (List<int> l) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Median(new List<int> {3,1,2,4,5});
            var expected1 = 3;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Median(new List<int> {-10,4,6,1000,10,20});
            var expected2 = 8.0;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Median(new List<int> {5});
            var expected3 = 5;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = Median(new List<int> {6,5});
            var expected4 = 5.5;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = Median(new List<int> {8,1,3,9,9,2,7});
            var expected5 = 7;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

        }
    }
}
```
