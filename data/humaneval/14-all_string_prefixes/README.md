# 14 -- Generate list of string prefixes

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
        /// Return list of all prefixes from shortest to longest of the input string
        /// >>> AllPrefixes('abc')
        /// ['a', 'ab', 'abc']
        /// 
        /// </summary>
        public static List<string> AllPrefixes (string string0) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = AllPrefixes("");
            var expected1 = new List<string> {};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = AllPrefixes("asdfgh");
            var expected2 = new List<string> {"a","as","asd","asdf","asdfg","asdfgh"};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = AllPrefixes("WWW");
            var expected3 = new List<string> {"W","WW","WWW"};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

        }
    }
}
```
