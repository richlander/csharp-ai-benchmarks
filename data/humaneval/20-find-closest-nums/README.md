
# 20 -- Find two closest numbers and return them in order

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
        /// From a supplied list of numbers (of length at least two) select and return two that are the closest to each
        /// other and return them in order (smaller number, larger number).
        /// >>> FindClosestElements([1.0, 2.0, 3.0, 4.0, 5.0, 2.2])
        /// (2.0, 2.2)
        /// >>> FindClosestElements([1.0, 2.0, 3.0, 4.0, 5.0, 2.0])
        /// (2.0, 2.0)
        /// 
        /// </summary>
        public static List<double> FindClosestElements (List<double> numbers) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = FindClosestElements(new List<double> {1.0,2.0,3.9,4.0,5.0,2.2});
            var expected1 = new List<double> {3.9,4.0};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = FindClosestElements(new List<double> {1.0,2.0,5.9,4.0,5.0});
            var expected2 = new List<double> {5.0,5.9};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = FindClosestElements(new List<double> {1.0,2.0,3.0,4.0,5.0,2.2});
            var expected3 = new List<double> {2.0,2.2};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = FindClosestElements(new List<double> {1.0,2.0,3.0,4.0,5.0,2.0});
            var expected4 = new List<double> {2.0,2.0};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = FindClosestElements(new List<double> {1.1,2.2,3.1,4.1,5.1});
            var expected5 = new List<double> {2.2,3.1};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

        }
    }
}
```
