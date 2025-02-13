# 12 -- Return longest string from a list

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
        /// Out of list of strings, return the Longest one. Return the first one in case of multiple
        /// strings of the same length. Return None in case the input list is empty.
        /// >>> Longest([])
        /// 
        /// >>> Longest(['a', 'b', 'c'])
        /// 'a'
        /// >>> Longest(['a', 'bb', 'ccc'])
        /// 'ccc'
        /// 
        /// </summary>
        public static object Longest (List<string> strings) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Longest(new List<string> {});
            var expected1 = null;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Longest(new List<string> {"x","y","z"});
            var expected2 = "x";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Longest(new List<string> {"x","yyy","zzzz","www","kkkk","abc"});
            var expected3 = "zzzz";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

        }
    }
}
```
