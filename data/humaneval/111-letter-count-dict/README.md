
# 111 -- Count and return most repeated letters in a string

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
        /// Given a string representing a space separated lowercase letters, return a dictionary
        /// of the letter with the most repetition and containing the corresponding count.
        /// If several letters have the same occurrence, return all of them.
        /// 
        /// Example:
        /// Histogram('a b c') == {'a': 1, 'b': 1, 'c': 1}
        /// Histogram('a b b a') == {'a': 2, 'b': 2}
        /// Histogram('a b c a b') == {'a': 2, 'b': 2}
        /// Histogram('b b b b a') == {'b': 4}
        /// Histogram('') == {}
        /// 
        /// 
        /// </summary>
        public static Dictionary<string, int> Histogram (string test) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Histogram("a b b a");
            var expected1 = new Dictionary<string, int> {{"a", 2},{"b", 2}};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Histogram("a b c a b");
            var expected2 = new Dictionary<string, int> {{"a", 2},{"b", 2}};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Histogram("a b c d g");
            var expected3 = new Dictionary<string, int> {{"a", 1},{"b", 1},{"c", 1},{"d", 1},{"g", 1}};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = Histogram("r t g");
            var expected4 = new Dictionary<string, int> {{"r", 1},{"t", 1},{"g", 1}};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = Histogram("b b b b a");
            var expected5 = new Dictionary<string, int> {{"b", 4}};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = Histogram("r t g");
            var expected6 = new Dictionary<string, int> {{"r", 1},{"t", 1},{"g", 1}};
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = Histogram("");
            var expected7 = new Dictionary<string, int> {};
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = Histogram("a");
            var expected8 = new Dictionary<string, int> {{"a", 1}};
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

        }
    }
}
```
