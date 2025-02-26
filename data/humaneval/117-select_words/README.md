# 117 -- Find words with n consonants in string s

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
        /// Given a string s and a natural number n, you have been tasked to implement 
        /// a function that returns a list of all words from string s that contain exactly 
        /// n consonants, in order these words appear in the string s.
        /// If the string s is empty then the function should return an empty list.
        /// Note: you may assume the input string contains only letters and spaces.
        /// Examples:
        /// SelectWords("Mary had a little lamb", 4) ==> ["little"]
        /// SelectWords("Mary had a little lamb", 3) ==> ["Mary", "lamb"]
        /// SelectWords("simple white space", 2) ==> []
        /// SelectWords("Hello world", 4) ==> ["world"]
        /// SelectWords("Uncle sam", 3) ==> ["Uncle"]
        /// 
        /// </summary>
        public static List<string> SelectWords (string s, int n) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = SelectWords("Mary had a little lamb",4);
            var expected1 = new List<string> {"little"};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = SelectWords("Mary had a little lamb",3);
            var expected2 = new List<string> {"Mary","lamb"};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = SelectWords("simple white space",2);
            var expected3 = new List<string> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = SelectWords("Hello world",4);
            var expected4 = new List<string> {"world"};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = SelectWords("Uncle sam",3);
            var expected5 = new List<string> {"Uncle"};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = SelectWords("",4);
            var expected6 = new List<string> {};
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = SelectWords("a b c d e f",1);
            var expected7 = new List<string> {"b","c","d","f"};
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

        }
    }
}
```
