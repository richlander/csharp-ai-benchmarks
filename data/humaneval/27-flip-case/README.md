
# 27 -- Flip string case

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
        /// For a given string, flip lowercase characters to uppercase and uppercase to lowercase.
        /// >>> FlipCase('Hello')
        /// 'hELLO'
        /// 
        /// </summary>
        public static string FlipCase (string string0) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = FlipCase("");
            var expected1 = "";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = FlipCase("Hello!");
            var expected2 = "hELLO!";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = FlipCase("These violent delights have violent ends");
            var expected3 = "tHESE VIOLENT DELIGHTS HAVE VIOLENT ENDS";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

        }
    }
}
```
