
# 16 -- Count distinct characters in a string

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
        /// Given a string, find out how many distinct characters (regardless of case) does it consist of
        /// >>> CountDistinctCharacters('xyzXYZ')
        /// 3
        /// >>> CountDistinctCharacters('Jerry')
        /// 4
        /// 
        /// </summary>
        public static int CountDistinctCharacters (string string0) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = CountDistinctCharacters("");
            var expected1 = 0;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = CountDistinctCharacters("abcde");
            var expected2 = 5;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = CountDistinctCharacters("abcdecadeCADE");
            var expected3 = 5;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = CountDistinctCharacters("aaaaAAAAaaaa");
            var expected4 = 1;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = CountDistinctCharacters("Jerry jERRY JeRRRY");
            var expected5 = 5;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

        }
    }
}
```
