# 28 -- Combine list of strings into one string

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
        /// Concatenate list of strings into a single string
        /// >>> Concatenate([])
        /// ''
        /// >>> Concatenate(['a', 'b', 'c'])
        /// 'abc'
        /// 
        /// </summary>
        public static string Concatenate (List<string> strings) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Concatenate(new List<string> {});
            var expected1 = "";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Concatenate(new List<string> {"x","y","z"});
            var expected2 = "xyz";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Concatenate(new List<string> {"x","y","z","w","k"});
            var expected3 = "xyzwk";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

        }
    }
}
```
