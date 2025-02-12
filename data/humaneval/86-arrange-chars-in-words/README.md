
# 86 -- Arrange characters in words by ASCII value

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
        /// Write a function that takes a string and returns an ordered version of it.
        /// Ordered version of string, is a string where all words (separated by space)
        /// are replaced by a new word where all the characters arranged in
        /// ascending order based on ascii value.
        /// Note: You should keep the order of words and blank spaces in the sentence.
        /// 
        /// For example:
        /// AntiShuffle('Hi') returns 'Hi'
        /// AntiShuffle('hello') returns 'ehllo'
        /// AntiShuffle('Hello World!!!') returns 'Hello !!!Wdlor'
        /// 
        /// </summary>
        public static string AntiShuffle (string s) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = AntiShuffle("Hi");
            var expected1 = "Hi";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = AntiShuffle("hello");
            var expected2 = "ehllo";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = AntiShuffle("number");
            var expected3 = "bemnru";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = AntiShuffle("abcd");
            var expected4 = "abcd";
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = AntiShuffle("Hello World!!!");
            var expected5 = "Hello !!!Wdlor";
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = AntiShuffle("");
            var expected6 = "";
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = AntiShuffle("Hi. My name is Mister Robot. How are you?");
            var expected7 = ".Hi My aemn is Meirst .Rboot How aer ?ouy";
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

        }
    }
}
```
