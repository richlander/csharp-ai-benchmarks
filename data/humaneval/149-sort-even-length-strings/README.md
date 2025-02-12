
# 149 -- Sort and return a list with even-length strings

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
        /// Write a function that accepts a list of strings as a parameter,
        /// deletes the strings that have odd lengths from it,
        /// and returns the resulted list with a sorted order,
        /// The list is always a list of strings and never an array of numbers,
        /// and it may contain duplicates.
        /// The order of the list should be ascending by length of each word, and you
        /// should return the list sorted by that rule.
        /// If two words have the same length, sort the list alphabetically.
        /// The function should return a list of strings in sorted order.
        /// You may assume that all words will have the same length.
        /// For example:
        /// assert list_sort(["aa", "a", "aaa"]) => ["aa"]
        /// assert list_sort(["ab", "a", "aaa", "cd"]) => ["ab", "cd"]
        /// 
        /// </summary>
        public static List<string> SortedListSum (List<string> lst) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = SortedListSum(new List<string> {"aa","a","aaa"});
            var expected1 = new List<string> {"aa"};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = SortedListSum(new List<string> {"school","AI","asdf","b"});
            var expected2 = new List<string> {"AI","asdf","school"};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = SortedListSum(new List<string> {"d","b","c","a"});
            var expected3 = new List<string> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = SortedListSum(new List<string> {"d","dcba","abcd","a"});
            var expected4 = new List<string> {"abcd","dcba"};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = SortedListSum(new List<string> {"AI","ai","au"});
            var expected5 = new List<string> {"AI","ai","au"};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = SortedListSum(new List<string> {"a","b","b","c","c","a"});
            var expected6 = new List<string> {};
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = SortedListSum(new List<string> {"aaaa","bbbb","dd","cc"});
            var expected7 = new List<string> {"cc","dd","aaaa","bbbb"};
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

        }
    }
}
```
