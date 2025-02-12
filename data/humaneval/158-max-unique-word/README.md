
# 158 -- Function to return the word with the most unique chars

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
        /// Write a function that accepts a list of strings.
        /// The list contains different words. Return the word with maximum number
        /// of unique characters. If multiple strings have maximum number of unique
        /// characters, return the one which comes first in lexicographical order.
        /// 
        /// FindMax(["name", "of", "string"]) == "string"
        /// FindMax(["name", "enam", "game"]) == "enam"
        /// FindMax(["aaaaaaa", "bb" ,"cc"]) == ""aaaaaaa"
        /// 
        /// </summary>
        public static string FindMax (List<string> words) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = FindMax(new List<string> {"name","of","string"});
            var expected1 = "string";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = FindMax(new List<string> {"name","enam","game"});
            var expected2 = "enam";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = FindMax(new List<string> {"aaaaaaa","bb","cc"});
            var expected3 = "aaaaaaa";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = FindMax(new List<string> {"abc","cba"});
            var expected4 = "abc";
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = FindMax(new List<string> {"play","this","game","of","footbott"});
            var expected5 = "footbott";
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = FindMax(new List<string> {"we","are","gonna","rock"});
            var expected6 = "gonna";
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = FindMax(new List<string> {"we","are","a","mad","nation"});
            var expected7 = "nation";
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = FindMax(new List<string> {"this","is","a","prrk"});
            var expected8 = "this";
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = FindMax(new List<string> {"b"});
            var expected9 = "b";
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

            var actual10 = FindMax(new List<string> {"play","play","play"});
            var expected10 = "play";
            var result10 = compareLogic.Compare(actual10, expected10);
            if (!result10.AreEqual) {throw new Exception("Exception --- test case 9 failed to pass");}

        }
    }
}
```
