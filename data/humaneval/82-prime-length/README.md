
# 82 -- Check if a string length is a prime number

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
        /// Write a function that takes a string and returns True if the string
        /// length is a prime number or False otherwise
        /// Examples
        /// PrimeLength('Hello') == True
        /// PrimeLength('abcdcba') == True
        /// PrimeLength('kittens') == True
        /// PrimeLength('orange') == False
        /// 
        /// </summary>
        public static bool PrimeLength (string string0) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = PrimeLength("Hello");
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = PrimeLength("abcdcba");
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = PrimeLength("kittens");
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = PrimeLength("orange");
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = PrimeLength("wow");
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = PrimeLength("world");
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = PrimeLength("MadaM");
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = PrimeLength("Wow");
            var expected8 = true;
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = PrimeLength("");
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

            var actual10 = PrimeLength("HI");
            var expected10 = true;
            var result10 = compareLogic.Compare(actual10, expected10);
            if (!result10.AreEqual) {throw new Exception("Exception --- test case 9 failed to pass");}

            var actual11 = PrimeLength("go");
            var expected11 = true;
            var result11 = compareLogic.Compare(actual11, expected11);
            if (!result11.AreEqual) {throw new Exception("Exception --- test case 10 failed to pass");}

            var actual12 = PrimeLength("gogo");
            var expected12 = false;
            var result12 = compareLogic.Compare(actual12, expected12);
            if (!result12.AreEqual) {throw new Exception("Exception --- test case 11 failed to pass");}

            var actual13 = PrimeLength("aaaaaaaaaaaaaaa");
            var expected13 = false;
            var result13 = compareLogic.Compare(actual13, expected13);
            if (!result13.AreEqual) {throw new Exception("Exception --- test case 12 failed to pass");}

            var actual14 = PrimeLength("Madam");
            var expected14 = true;
            var result14 = compareLogic.Compare(actual14, expected14);
            if (!result14.AreEqual) {throw new Exception("Exception --- test case 13 failed to pass");}

            var actual15 = PrimeLength("M");
            var expected15 = false;
            var result15 = compareLogic.Compare(actual15, expected15);
            if (!result15.AreEqual) {throw new Exception("Exception --- test case 14 failed to pass");}

            var actual16 = PrimeLength("0");
            var expected16 = false;
            var result16 = compareLogic.Compare(actual16, expected16);
            if (!result16.AreEqual) {throw new Exception("Exception --- test case 15 failed to pass");}

        }
    }
}
```
