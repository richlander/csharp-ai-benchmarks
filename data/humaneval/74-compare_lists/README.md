# 74 -- Return list with fewer total chars

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
        /// Write a function that accepts two lists of strings and returns the list that has 
        /// total number of chars in the all strings of the list less than the other list.
        /// 
        /// if the two lists have the same number of chars, return the first list.
        /// 
        /// Examples
        /// TotalMatch([], []) ➞ []
        /// TotalMatch(['hi', 'admin'], ['hI', 'Hi']) ➞ ['hI', 'Hi']
        /// TotalMatch(['hi', 'admin'], ['hi', 'hi', 'admin', 'project']) ➞ ['hi', 'admin']
        /// TotalMatch(['hi', 'admin'], ['hI', 'hi', 'hi']) ➞ ['hI', 'hi', 'hi']
        /// TotalMatch(['4'], ['1', '2', '3', '4', '5']) ➞ ['4']
        /// 
        /// </summary>
        public static List<string> TotalMatch (List<string> lst1, List<string> lst2) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = TotalMatch(new List<string> {},new List<string> {});
            var expected1 = new List<string> {};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = TotalMatch(new List<string> {"hi","admin"},new List<string> {"hi","hi"});
            var expected2 = new List<string> {"hi","hi"};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = TotalMatch(new List<string> {"hi","admin"},new List<string> {"hi","hi","admin","project"});
            var expected3 = new List<string> {"hi","admin"};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = TotalMatch(new List<string> {"4"},new List<string> {"1","2","3","4","5"});
            var expected4 = new List<string> {"4"};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = TotalMatch(new List<string> {"hi","admin"},new List<string> {"hI","Hi"});
            var expected5 = new List<string> {"hI","Hi"};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = TotalMatch(new List<string> {"hi","admin"},new List<string> {"hI","hi","hi"});
            var expected6 = new List<string> {"hI","hi","hi"};
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = TotalMatch(new List<string> {"hi","admin"},new List<string> {"hI","hi","hii"});
            var expected7 = new List<string> {"hi","admin"};
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = TotalMatch(new List<string> {},new List<string> {"this"});
            var expected8 = new List<string> {};
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = TotalMatch(new List<string> {"this"},new List<string> {});
            var expected9 = new List<string> {};
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

        }
    }
}
```
