
# 103 -- Compute average, round, convert to binary

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
        /// You are given two positive integers n and m, and your task is to compute the
        /// average of the integers from n through m (including n and m). 
        /// Round the answer to the nearest integer and convert that to binary.
        /// If n is greater than m, return -1.
        /// Example:
        /// RoundedAvg(1, 5) => "0b11"
        /// RoundedAvg(7, 5) => -1
        /// RoundedAvg(10, 20) => "0b1111"
        /// RoundedAvg(20, 33) => "0b11010"
        /// 
        /// </summary>
        public static object RoundedAvg (int n, int m) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = RoundedAvg(1,5);
            var expected1 = "0b11";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = RoundedAvg(7,13);
            var expected2 = "0b1010";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = RoundedAvg(964,977);
            var expected3 = "0b1111001010";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = RoundedAvg(996,997);
            var expected4 = "0b1111100100";
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = RoundedAvg(560,851);
            var expected5 = "0b1011000010";
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = RoundedAvg(185,546);
            var expected6 = "0b101101110";
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = RoundedAvg(362,496);
            var expected7 = "0b110101101";
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = RoundedAvg(350,902);
            var expected8 = "0b1001110010";
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = RoundedAvg(197,233);
            var expected9 = "0b11010111";
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

            var actual10 = RoundedAvg(7,5);
            var expected10 = -1;
            var result10 = compareLogic.Compare(actual10, expected10);
            if (!result10.AreEqual) {throw new Exception("Exception --- test case 9 failed to pass");}

            var actual11 = RoundedAvg(5,1);
            var expected11 = -1;
            var result11 = compareLogic.Compare(actual11, expected11);
            if (!result11.AreEqual) {throw new Exception("Exception --- test case 10 failed to pass");}

            var actual12 = RoundedAvg(5,5);
            var expected12 = "0b101";
            var result12 = compareLogic.Compare(actual12, expected12);
            if (!result12.AreEqual) {throw new Exception("Exception --- test case 11 failed to pass");}

        }
    }
}
```
