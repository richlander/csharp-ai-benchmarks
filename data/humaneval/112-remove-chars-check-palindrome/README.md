
# 112 -- Remove characters in s found in c; check palindrome

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
        /// Task
        /// We are given two strings s and c, you have to deleted all the characters in s that are equal to any character in c
        /// then check if the result string is palindrome.
        /// A string is called palindrome if it reads the same backward as forward.
        /// You should return a tuple containing the result string and True/False for the check.
        /// Example
        /// For s = "abcde", c = "ae", the result should be ('bcd',False)
        /// For s = "abcdef", c = "b"  the result should be ('acdef',False)
        /// For s = "abcdedcba", c = "ab", the result should be ('cdedc',True)
        /// 
        /// </summary>
        public static List<object> ReverseDelete (string s, string c) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = ReverseDelete("abcde","ae");
            var expected1 = new List<object> {"bcd",false};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = ReverseDelete("abcdef","b");
            var expected2 = new List<object> {"acdef",false};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = ReverseDelete("abcdedcba","ab");
            var expected3 = new List<object> {"cdedc",true};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = ReverseDelete("dwik","w");
            var expected4 = new List<object> {"dik",false};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = ReverseDelete("a","a");
            var expected5 = new List<object> {"",true};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = ReverseDelete("abcdedcba","");
            var expected6 = new List<object> {"abcdedcba",true};
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = ReverseDelete("abcdedcba","v");
            var expected7 = new List<object> {"abcdedcba",true};
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = ReverseDelete("vabba","v");
            var expected8 = new List<object> {"abba",true};
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = ReverseDelete("mamma","mia");
            var expected9 = new List<object> {"",true};
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

        }
    }
}
```
