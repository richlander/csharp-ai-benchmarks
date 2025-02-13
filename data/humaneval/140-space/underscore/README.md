# 140 -- Replace spaces with underscores or hyphen

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
        /// Given a string text, replace all spaces in it with underscores, 
        /// and if a string has more than 2 consecutive spaces, 
        /// then replace all consecutive spaces with - 
        /// 
        /// FixSpaces("Example") == "Example"
        /// FixSpaces("Example 1") == "Example_1"
        /// FixSpaces(" Example 2") == "_Example_2"
        /// FixSpaces(" Example   3") == "_Example-3"
        /// 
        /// </summary>
        public static string FixSpaces (string text) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = FixSpaces("Example");
            var expected1 = "Example";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = FixSpaces("Mudasir Hanif ");
            var expected2 = "Mudasir_Hanif_";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = FixSpaces("Yellow Yellow  Dirty  Fellow");
            var expected3 = "Yellow_Yellow__Dirty__Fellow";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = FixSpaces("Exa   mple");
            var expected4 = "Exa-mple";
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = FixSpaces("   Exa 1 2 2 mple");
            var expected5 = "-Exa_1_2_2_mple";
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

        }
    }
}
```
