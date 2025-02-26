# 18 -- Count overlapping substrings in a string

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
        /// Find how many times a given substring can be found in the original string. Count overlaping cases.
        /// >>> HowManyTimes('', 'a')
        /// 0
        /// >>> HowManyTimes('aaa', 'a')
        /// 3
        /// >>> HowManyTimes('aaaa', 'aa')
        /// 3
        /// 
        /// </summary>
        public static int HowManyTimes (string string0, string substring) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = HowManyTimes("","x");
            var expected1 = 0;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = HowManyTimes("xyxyxyx","x");
            var expected2 = 4;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = HowManyTimes("cacacacac","cac");
            var expected3 = 4;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = HowManyTimes("john doe","john");
            var expected4 = 1;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

        }
    }
}
```
