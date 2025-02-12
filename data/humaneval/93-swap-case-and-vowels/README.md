
# 93 -- Swap case and replace vowels in a message

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
        /// Write a function that takes a message, and Encodes in such a 
        /// way that it swaps case of all letters, replaces all vowels in 
        /// the message with the letter that appears 2 places ahead of that 
        /// vowel in the english alphabet. 
        /// Assume only letters. 
        /// 
        /// Examples:
        /// >>> Encode('test')
        /// 'TGST'
        /// >>> Encode('This is a message')
        /// 'tHKS KS C MGSSCGG'
        /// 
        /// </summary>
        public static string Encode (string message) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Encode("TEST");
            var expected1 = "tgst";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Encode("Mudasir");
            var expected2 = "mWDCSKR";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Encode("YES");
            var expected3 = "ygs";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = Encode("This is a message");
            var expected4 = "tHKS KS C MGSSCGG";
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = Encode("I DoNt KnOw WhAt tO WrItE");
            var expected5 = "k dQnT kNqW wHcT Tq wRkTg";
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

        }
    }
}
```
