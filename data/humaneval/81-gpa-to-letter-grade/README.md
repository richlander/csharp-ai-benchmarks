
# 81 -- Convert GPAs to letter grades based on table

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
        /// It is the last week of the semester and the teacher has to give the grades
        /// to students. The teacher has been making her own algorithm for grading.
        /// The only problem is, she has lost the code she used for grading.
        /// She has given you a list of GPAs for some students and you have to write 
        /// a function that can output a list of letter grades using the following table:
        /// GPA       |    Letter grade
        /// 4.0                A+
        /// > 3.7                A 
        /// > 3.3                A- 
        /// > 3.0                B+
        /// > 2.7                B 
        /// > 2.3                B-
        /// > 2.0                C+
        /// > 1.7                C
        /// > 1.3                C-
        /// > 1.0                D+ 
        /// > 0.7                D 
        /// > 0.0                D-
        /// 0.0                E
        /// 
        /// 
        /// Example:
        /// grade_equation([4.0, 3, 1.7, 2, 3.5]) ==> ['A+', 'B', 'C-', 'C', 'A-']
        /// 
        /// </summary>
        public static List<string> NumericalLetterGrade (List<object> grades) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = NumericalLetterGrade(new List<object> {4.0,3,1.7,2,3.5});
            var expected1 = new List<string> {"A+","B","C-","C","A-"};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = NumericalLetterGrade(new List<object> {1.2});
            var expected2 = new List<string> {"D+"};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = NumericalLetterGrade(new List<object> {0.5});
            var expected3 = new List<string> {"D-"};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = NumericalLetterGrade(new List<object> {0.0});
            var expected4 = new List<string> {"E"};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = NumericalLetterGrade(new List<object> {1,0.3,1.5,2.8,3.3});
            var expected5 = new List<string> {"D","D-","C-","B","B+"};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = NumericalLetterGrade(new List<object> {0,0.7});
            var expected6 = new List<string> {"E","D-"};
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

        }
    }
}
```
