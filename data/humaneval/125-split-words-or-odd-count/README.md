
# 125 -- Split words or count odd-order letters

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
        /// 
        /// Given a string of words, return a list of words split on whitespace, if no whitespaces exists in the text you
        /// should split on commas ',' if no commas exists you should return the number of lower-case letters with odd order in the
        /// alphabet, ord('a') = 0, ord('b') = 1, ... ord('z') = 25
        /// Examples
        /// SplitWords("Hello world!") ➞ ["Hello", "world!"]
        /// SplitWords("Hello,world!") ➞ ["Hello", "world!"]
        /// SplitWords("abcdef") == 3 
        /// 
        /// </summary>
        public static object SplitWords (string txt) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = SplitWords("Hello world!");
            var expected1 = new List<object> {"Hello","world!"};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = SplitWords("Hello,world!");
            var expected2 = new List<object> {"Hello","world!"};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = SplitWords("Hello world,!");
            var expected3 = new List<object> {"Hello","world,!"};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = SplitWords("Hello,Hello,world !");
            var expected4 = new List<object> {"Hello,Hello,world","!"};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = SplitWords("abcdef");
            var expected5 = 3;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = SplitWords("aaabb");
            var expected6 = 2;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = SplitWords("aaaBb");
            var expected7 = 1;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = SplitWords("");
            var expected8 = 0;
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

        }
    }
}
```
