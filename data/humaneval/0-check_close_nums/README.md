# 0 -- Check if list has numbers closer than threshold

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
        /// Check if in given list of numbers, are any two numbers closer to each other than
        /// given threshold.
        /// >>> HasCloseElements([1.0, 2.0, 3.0], 0.5)
        /// False
        /// >>> HasCloseElements([1.0, 2.8, 3.0, 4.0, 5.0, 2.0], 0.3)
        /// True
        /// 
        /// </summary>
        public static bool HasCloseElements (List<double> numbers, double threshold) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = HasCloseElements(new List<double> {1.0,2.0,3.9,4.0,5.0,2.2},0.3);
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = HasCloseElements(new List<double> {1.0,2.0,3.9,4.0,5.0,2.2},0.05);
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = HasCloseElements(new List<double> {1.0,2.0,5.9,4.0,5.0},0.95);
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = HasCloseElements(new List<double> {1.0,2.0,5.9,4.0,5.0},0.8);
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = HasCloseElements(new List<double> {1.0,2.0,3.0,4.0,5.0,2.0},0.1);
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = HasCloseElements(new List<double> {1.1,2.2,3.1,4.1,5.1},1.0);
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = HasCloseElements(new List<double> {1.1,2.2,3.1,4.1,5.1},0.5);
            var expected7 = false;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

        }
    }
}
```
