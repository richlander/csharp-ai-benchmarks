
# 11 -- Perform XOR on binary strings a and b

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
        /// Input are two strings a and b consisting only of 1s and 0s.
        /// Perform binary XOR on these inputs and return result also as a string.
        /// >>> StringXor('010', '110')
        /// '100'
        /// 
        /// </summary>
        public static string StringXor (string a, string b) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = StringXor("111000","101010");
            var expected1 = "010010";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = StringXor("1","1");
            var expected2 = "0";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = StringXor("0101","0000");
            var expected3 = "0101";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

        }
    }
}
```
