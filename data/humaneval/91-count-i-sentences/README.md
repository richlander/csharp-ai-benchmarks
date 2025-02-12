
# 91 -- Count sentences starting with "I"

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
        /// You'll be given a string of words, and your task is to count the number
        /// of boredoms. A boredom is a sentence that starts with the word "I".
        /// Sentences are delimited by '.', '?' or '!'.
        /// 
        /// For example:
        /// >>> IsBored("Hello world")
        /// 0
        /// >>> IsBored("The sky is blue. The sun is shining. I love this weather")
        /// 1
        /// 
        /// </summary>
        public static int IsBored (string S) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = IsBored("Hello world");
            var expected1 = 0;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = IsBored("Is the sky blue?");
            var expected2 = 0;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = IsBored("I love It !");
            var expected3 = 1;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = IsBored("bIt");
            var expected4 = 0;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = IsBored("I feel good today. I will be productive. will kill It");
            var expected5 = 2;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = IsBored("You and I are going for a walk");
            var expected6 = 0;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

        }
    }
}
```
