# 101 -- Split strings into words, return as array

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
        /// You will be given a string of words separated by commas or spaces. Your task is
        /// to split the string into words and return an array of the words.
        /// 
        /// For example:
        /// WordsString("Hi, my name is John") == ["Hi", "my", "name", "is", "John"]
        /// WordsString("One, two, three, four, five, six") == ["One", "two", "three", "four", "five", "six"]
        /// 
        /// </summary>
        public static List<string> WordsString (string s) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = WordsString("Hi, my name is John");
            var expected1 = new List<string> {"Hi","my","name","is","John"};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = WordsString("One, two, three, four, five, six");
            var expected2 = new List<string> {"One","two","three","four","five","six"};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = WordsString("Hi, my name");
            var expected3 = new List<string> {"Hi","my","name"};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = WordsString("One,, two, three, four, five, six,");
            var expected4 = new List<string> {"One","two","three","four","five","six"};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = WordsString("");
            var expected5 = new List<string> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = WordsString("ahmed     , gamal");
            var expected6 = new List<string> {"ahmed","gamal"};
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

        }
    }
}
```
