# 79 -- Convert decimal to binary with 'db' padding

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
        /// You will be given a number in decimal form and your task is to convert it to
        /// binary format. The function should return a string, with each character representing a binary
        /// number. Each character in the string will be '0' or '1'.
        /// 
        /// There will be an extra couple of characters 'db' at the beginning and at the end of the string.
        /// The extra characters are there to help with the format.
        /// 
        /// Examples:
        /// DecimalToBinary(15)   # returns "db1111db"
        /// DecimalToBinary(32)   # returns "db100000db"
        /// 
        /// </summary>
        public static string DecimalToBinary (int decimal) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = DecimalToBinary(0);
            var expected1 = "db0db";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = DecimalToBinary(32);
            var expected2 = "db100000db";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = DecimalToBinary(103);
            var expected3 = "db1100111db";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = DecimalToBinary(15);
            var expected4 = "db1111db";
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

        }
    }
}
```
