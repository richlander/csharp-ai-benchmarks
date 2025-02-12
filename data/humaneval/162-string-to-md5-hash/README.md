
# 162 -- MD5 hash a string; return None for empty input

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
        /// Given a string 'text', return its md5 hash equivalent string.
        /// If 'text' is an empty string, return None.
        /// 
        /// >>> StringToMd5('Hello world') == '3e25960a79dbc69b674cd4ec67a72c62'
        /// 
        /// </summary>
        public static object StringToMd5 (string text) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = StringToMd5("Hello world");
            var expected1 = "3e25960a79dbc69b674cd4ec67a72c62";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = StringToMd5("");
            var expected2 = null;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = StringToMd5("A B C");
            var expected3 = "0ef78513b0cb8cef12743f5aeb35f888";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = StringToMd5("password");
            var expected4 = "5f4dcc3b5aa765d61d8327deb882cf99";
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

        }
    }
}
```
