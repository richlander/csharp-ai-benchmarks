
# 95 -- Check dictionary for consistent key case

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
        /// Given a dictionary, return True if all keys are strings in lower 
        /// case or all keys are strings in upper case, else return False.
        /// The function should return False is the given dictionary is empty.
        /// Examples:
        /// CheckDictCase({"a":"apple", "b":"banana"}) should return True.
        /// CheckDictCase({"a":"apple", "A":"banana", "B":"banana"}) should return False.
        /// CheckDictCase({"a":"apple", 8:"banana", "a":"apple"}) should return False.
        /// CheckDictCase({"Name":"John", "Age":"36", "City":"Houston"}) should return False.
        /// CheckDictCase({"STATE":"NC", "ZIP":"12345" }) should return True.
        /// 
        /// </summary>
        public static bool CheckDictCase (Dictionary<object, string> dict) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = CheckDictCase(new Dictionary<object, string> {{"p", "pineapple"},{"b", "banana"}});
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = CheckDictCase(new Dictionary<object, string> {{"p", "pineapple"},{"A", "banana"},{"B", "banana"}});
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = CheckDictCase(new Dictionary<object, string> {{"p", "pineapple"},{5, "banana"},{"a", "apple"}});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = CheckDictCase(new Dictionary<object, string> {{"Name", "John"},{"Age", "36"},{"City", "Houston"}});
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = CheckDictCase(new Dictionary<object, string> {{"STATE", "NC"},{"ZIP", "12345"}});
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = CheckDictCase(new Dictionary<object, string> {{"fruit", "Orange"},{"taste", "Sweet"}});
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = CheckDictCase(new Dictionary<object, string> {});
            var expected7 = false;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

        }
    }
}
```
