
# 17 -- Parse musical notes into beat duration list

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
        /// Input to this function is a string representing musical notes in a special ASCII format.
        /// Your task is to parse this string and return list of integers corresponding to how many beats does each
        /// not last.
        /// 
        /// Here is a legend:
        /// 'o' - whole note, lasts four beats
        /// 'o|' - half note, lasts two beats
        /// '.|' - quater note, lasts one beat
        /// 
        /// >>> ParseMusic('o o| .| o| o| .| .| .| .| o o')
        /// [4, 2, 1, 2, 2, 1, 1, 1, 1, 4, 4]
        /// 
        /// </summary>
        public static List<int> ParseMusic (string music_string) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = ParseMusic("");
            var expected1 = new List<int> {};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = ParseMusic("o o o o");
            var expected2 = new List<int> {4,4,4,4};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = ParseMusic(".| .| .| .|");
            var expected3 = new List<int> {1,1,1,1};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = ParseMusic("o| o| .| .| o o o o");
            var expected4 = new List<int> {2,2,1,1,4,4,4,4};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = ParseMusic("o| .| o| .| o o| o o|");
            var expected5 = new List<int> {2,1,2,1,4,2,4,2};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

        }
    }
}
```
