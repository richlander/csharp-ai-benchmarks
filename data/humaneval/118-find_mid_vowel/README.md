# 118 -- Find closest vowel between consonants

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
        /// You are given a word. Your task is to find the closest vowel that stands between 
        /// two consonants from the right side of the word (case sensitive).
        /// 
        /// Vowels in the beginning and ending doesn't count. Return empty string if you didn't
        /// find any vowel met the above condition. 
        /// 
        /// You may assume that the given string contains English letter only.
        /// 
        /// Example:
        /// GetClosestVowel("yogurt") ==> "u"
        /// GetClosestVowel("FULL") ==> "U"
        /// GetClosestVowel("quick") ==> ""
        /// GetClosestVowel("ab") ==> ""
        /// 
        /// </summary>
        public static string GetClosestVowel (string word) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = GetClosestVowel("yogurt");
            var expected1 = "u";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = GetClosestVowel("full");
            var expected2 = "u";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = GetClosestVowel("easy");
            var expected3 = "";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = GetClosestVowel("eAsy");
            var expected4 = "";
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = GetClosestVowel("ali");
            var expected5 = "";
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = GetClosestVowel("bad");
            var expected6 = "a";
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = GetClosestVowel("most");
            var expected7 = "o";
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = GetClosestVowel("ab");
            var expected8 = "";
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = GetClosestVowel("ba");
            var expected9 = "";
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

            var actual10 = GetClosestVowel("quick");
            var expected10 = "";
            var result10 = compareLogic.Compare(actual10, expected10);
            if (!result10.AreEqual) {throw new Exception("Exception --- test case 9 failed to pass");}

            var actual11 = GetClosestVowel("anime");
            var expected11 = "i";
            var result11 = compareLogic.Compare(actual11, expected11);
            if (!result11.AreEqual) {throw new Exception("Exception --- test case 10 failed to pass");}

            var actual12 = GetClosestVowel("Asia");
            var expected12 = "";
            var result12 = compareLogic.Compare(actual12, expected12);
            if (!result12.AreEqual) {throw new Exception("Exception --- test case 11 failed to pass");}

            var actual13 = GetClosestVowel("Above");
            var expected13 = "o";
            var result13 = compareLogic.Compare(actual13, expected13);
            if (!result13.AreEqual) {throw new Exception("Exception --- test case 12 failed to pass");}

        }
    }
}
```
