
# 143 -- Extract words with prime lengths

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
        /// You are given a string representing a sentence,
        /// the sentence contains some words separated by a space,
        /// and you have to return a string that contains the words from the original sentence,
        /// whose lengths are prime numbers,
        /// the order of the words in the new string should be the same as the original one.
        /// 
        /// Example 1:
        /// Input: sentence = "This is a test"
        /// Output: "is"
        /// 
        /// Example 2:
        /// Input: sentence = "lets go for swimming"
        /// Output: "go for"
        /// 
        /// Constraints:
        /// * 1 <= len(sentence) <= 100
        /// * sentence contains only letters
        /// 
        /// </summary>
        public static string WordsInSentence (string sentence) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = WordsInSentence("This is a test");
            var expected1 = "is";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = WordsInSentence("lets go for swimming");
            var expected2 = "go for";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = WordsInSentence("there is no place available here");
            var expected3 = "there is no place";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = WordsInSentence("Hi I am Hussein");
            var expected4 = "Hi am Hussein";
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = WordsInSentence("go for it");
            var expected5 = "go for it";
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = WordsInSentence("here");
            var expected6 = "";
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = WordsInSentence("here is");
            var expected7 = "is";
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

        }
    }
}
```
