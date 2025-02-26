# 15 -- Space-delimited numbers from 0 to n

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
        /// Return a string containing space-delimited numbers starting from 0 upto n inclusive.
        /// >>> StringSequence(0)
        /// '0'
        /// >>> StringSequence(5)
        /// '0 1 2 3 4 5'
        /// 
        /// </summary>
        public static string StringSequence (int n) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = StringSequence(0);
            var expected1 = "0";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = StringSequence(3);
            var expected2 = "0 1 2 3";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = StringSequence(10);
            var expected3 = "0 1 2 3 4 5 6 7 8 9 10";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

        }
    }
}
```
