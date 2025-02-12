
# 113 -- Count odd digits in each string

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
        /// Given a list of strings, where each string consists of only digits, return a list.
        /// Each element i of the output should be "the number of odd elements in the
        /// string i of the input." where all the i's should be replaced by the number
        /// of odd digits in the i'th string of the input.
        /// 
        /// >>> OddCount(['1234567'])
        /// ["the number of odd elements 4n the str4ng 4 of the 4nput."]
        /// >>> OddCount(['3',"11111111"])
        /// ["the number of odd elements 1n the str1ng 1 of the 1nput.",
        /// "the number of odd elements 8n the str8ng 8 of the 8nput."]
        /// 
        /// </summary>
        public static List<string> OddCount (List<string> lst) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = OddCount(new List<string> {"1234567"});
            var expected1 = new List<string> {"the number of odd elements 4n the str4ng 4 of the 4nput."};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = OddCount(new List<string> {"3","11111111"});
            var expected2 = new List<string> {"the number of odd elements 1n the str1ng 1 of the 1nput.","the number of odd elements 8n the str8ng 8 of the 8nput."};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = OddCount(new List<string> {"271","137","314"});
            var expected3 = new List<string> {"the number of odd elements 2n the str2ng 2 of the 2nput.","the number of odd elements 3n the str3ng 3 of the 3nput.","the number of odd elements 2n the str2ng 2 of the 2nput."};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

        }
    }
}
```
