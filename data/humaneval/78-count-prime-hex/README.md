
# 78 -- Count prime hex digits in a string

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
        /// You have been tasked to write a function that receives 
        /// a hexadecimal number as a string and counts the number of hexadecimal 
        /// digits that are primes (prime number, or a prime, is a natural number 
        /// greater than 1 that is not a product of two smaller natural numbers).
        /// Hexadecimal digits are 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, A, B, C, D, E, F.
        /// Prime numbers are 2, 3, 5, 7, 11, 13, 17,...
        /// So you have to determine a number of the following digits: 2, 3, 5, 7, 
        /// B (=decimal 11), D (=decimal 13).
        /// Note: you may assume the input is always correct or empty string, 
        /// and symbols A,B,C,D,E,F are always uppercase.
        /// Examples:
        /// For num = "AB" the output should be 1.
        /// For num = "1077E" the output should be 2.
        /// For num = "ABED1A33" the output should be 4.
        /// For num = "123456789ABCDEF0" the output should be 6.
        /// For num = "2020" the output should be 2.
        /// 
        /// </summary>
        public static int HexKey (object num) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = HexKey("AB");
            var expected1 = 1;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = HexKey("1077E");
            var expected2 = 2;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = HexKey("ABED1A33");
            var expected3 = 4;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = HexKey("2020");
            var expected4 = 2;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = HexKey("123456789ABCDEF0");
            var expected5 = 6;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = HexKey("112233445566778899AABBCCDDEEFF00");
            var expected6 = 12;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = HexKey(new List<object> {});
            var expected7 = 0;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

        }
    }
}
```
