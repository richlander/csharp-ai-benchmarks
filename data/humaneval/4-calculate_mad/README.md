# 4 -- Calculate Mean Absolute Deviation

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
        /// For a given list of input numbers, calculate Mean Absolute Deviation
        /// around the mean of this dataset.
        /// Mean Absolute Deviation is the average absolute difference between each
        /// element and a centerpoint (mean in this case):
        /// MAD = average | x - x_mean |
        /// >>> MeanAbsoluteDeviation([1.0, 2.0, 3.0, 4.0])
        /// 1.0
        /// 
        /// </summary>
        public static double MeanAbsoluteDeviation (List<double> numbers) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = MeanAbsoluteDeviation(new List<double> {1.0,2.0,3.0});
            var expected1 = 0.6666666666666666;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = MeanAbsoluteDeviation(new List<double> {1.0,2.0,3.0,4.0});
            var expected2 = 1.0;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = MeanAbsoluteDeviation(new List<double> {1.0,2.0,3.0,4.0,5.0});
            var expected3 = 1.2;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

        }
    }
}
```
