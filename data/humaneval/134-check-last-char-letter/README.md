
# 134 -- Determine if last char is a standalone letter

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
        /// Create a function that returns True if the last character
        /// of a given string is an alphabetical character and is not
        /// a part of a word, and False otherwise.
        /// Note: "word" is a group of characters separated by space.
        /// 
        /// Examples:
        /// CheckIfLastCharIsALetter("apple pie") ➞ False
        /// CheckIfLastCharIsALetter("apple pi e") ➞ True
        /// CheckIfLastCharIsALetter("apple pi e ") ➞ False
        /// CheckIfLastCharIsALetter("") ➞ False 
        /// 
        /// </summary>
        public static bool CheckIfLastCharIsALetter (string txt) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = CheckIfLastCharIsALetter("apple");
            var expected1 = false;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = CheckIfLastCharIsALetter("apple pi e");
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = CheckIfLastCharIsALetter("eeeee");
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = CheckIfLastCharIsALetter("A");
            var expected4 = true;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = CheckIfLastCharIsALetter("Pumpkin pie ");
            var expected5 = false;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = CheckIfLastCharIsALetter("Pumpkin pie 1");
            var expected6 = false;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = CheckIfLastCharIsALetter("");
            var expected7 = false;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = CheckIfLastCharIsALetter("eeeee e ");
            var expected8 = false;
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = CheckIfLastCharIsALetter("apple pie");
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

            var actual10 = CheckIfLastCharIsALetter("apple pi e ");
            var expected10 = false;
            var result10 = compareLogic.Compare(actual10, expected10);
            if (!result10.AreEqual) {throw new Exception("Exception --- test case 9 failed to pass");}

        }
    }
}
```
