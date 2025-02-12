
# 124 -- Validate dates using format mm-dd-yyyy

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
        /// You have to write a function which validates a given date string and
        /// returns True if the date is valid otherwise False.
        /// The date is valid if all of the following rules are satisfied:
        /// 1. The date string is not empty.
        /// 2. The number of days is not less than 1 or higher than 31 days for months 1,3,5,7,8,10,12. And the number of days is not less than 1 or higher than 30 days for months 4,6,9,11. And, the number of days is not less than 1 or higher than 29 for the month 2.
        /// 3. The months should not be less than 1 or higher than 12.
        /// 4. The date should be in the format: mm-dd-yyyy
        /// 
        /// for example: 
        /// ValidDate('03-11-2000') => True
        /// 
        /// ValidDate('15-01-2012') => False
        /// 
        /// ValidDate('04-0-2040') => False
        /// 
        /// ValidDate('06-04-2020') => True
        /// 
        /// ValidDate('06/04/2020') => False
        /// 
        /// </summary>
        public static bool ValidDate (string date) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = ValidDate("03-11-2000");
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = ValidDate("15-01-2012");
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = ValidDate("04-0-2040");
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = ValidDate("06-04-2020");
            var expected4 = true;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = ValidDate("01-01-2007");
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = ValidDate("03-32-2011");
            var expected6 = false;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = ValidDate("");
            var expected7 = false;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = ValidDate("04-31-3000");
            var expected8 = false;
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = ValidDate("06-06-2005");
            var expected9 = true;
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

            var actual10 = ValidDate("21-31-2000");
            var expected10 = false;
            var result10 = compareLogic.Compare(actual10, expected10);
            if (!result10.AreEqual) {throw new Exception("Exception --- test case 9 failed to pass");}

            var actual11 = ValidDate("04-12-2003");
            var expected11 = true;
            var result11 = compareLogic.Compare(actual11, expected11);
            if (!result11.AreEqual) {throw new Exception("Exception --- test case 10 failed to pass");}

            var actual12 = ValidDate("04122003");
            var expected12 = false;
            var result12 = compareLogic.Compare(actual12, expected12);
            if (!result12.AreEqual) {throw new Exception("Exception --- test case 11 failed to pass");}

            var actual13 = ValidDate("20030412");
            var expected13 = false;
            var result13 = compareLogic.Compare(actual13, expected13);
            if (!result13.AreEqual) {throw new Exception("Exception --- test case 12 failed to pass");}

            var actual14 = ValidDate("2003-04");
            var expected14 = false;
            var result14 = compareLogic.Compare(actual14, expected14);
            if (!result14.AreEqual) {throw new Exception("Exception --- test case 13 failed to pass");}

            var actual15 = ValidDate("2003-04-12");
            var expected15 = false;
            var result15 = compareLogic.Compare(actual15, expected15);
            if (!result15.AreEqual) {throw new Exception("Exception --- test case 14 failed to pass");}

            var actual16 = ValidDate("04-2003");
            var expected16 = false;
            var result16 = compareLogic.Compare(actual16, expected16);
            if (!result16.AreEqual) {throw new Exception("Exception --- test case 15 failed to pass");}

        }
    }
}
```
