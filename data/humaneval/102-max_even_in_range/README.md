# 102 -- Find largest even integer in [x, y], or -1

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
        /// This function takes two positive numbers x and y and returns the
        /// biggest even integer number that is in the range [x, y] inclusive. If 
        /// there's no such number, then the function should return -1.
        /// 
        /// For example:
        /// ChooseNum(12, 15) = 14
        /// ChooseNum(13, 12) = -1
        /// 
        /// </summary>
        public static int ChooseNum (int x, int y) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = ChooseNum(12,15);
            var expected1 = 14;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = ChooseNum(13,12);
            var expected2 = -1;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = ChooseNum(33,12354);
            var expected3 = 12354;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = ChooseNum(5234,5233);
            var expected4 = -1;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = ChooseNum(6,29);
            var expected5 = 28;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = ChooseNum(27,10);
            var expected6 = -1;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = ChooseNum(7,7);
            var expected7 = -1;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = ChooseNum(546,546);
            var expected8 = 546;
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

        }
    }
}
```
