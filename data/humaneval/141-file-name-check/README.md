
# 141 -- File name validation function

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
        /// Create a function which takes a string representing a file's name, and returns
        /// 'Yes' if the the file's name is valid, and returns 'No' otherwise.
        /// A file's name is considered to be valid if and only if all the following conditions 
        /// are met:
        /// - There should not be more than three digits ('0'-'9') in the file's name.
        /// - The file's name contains exactly one dot '.'
        /// - The substring before the dot should not be empty, and it starts with a letter from 
        /// the latin alphapet ('a'-'z' and 'A'-'Z').
        /// - The substring after the dot should be one of these: ['txt', 'exe', 'dll']
        /// Examples:
        /// FileNameCheck("example.txt") # => 'Yes'
        /// FileNameCheck("1example.dll") # => 'No' (the name should start with a latin alphapet letter)
        /// 
        /// </summary>
        public static string FileNameCheck (string file_name) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = FileNameCheck("example.txt");
            var expected1 = "Yes";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = FileNameCheck("1example.dll");
            var expected2 = "No";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = FileNameCheck("s1sdf3.asd");
            var expected3 = "No";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = FileNameCheck("K.dll");
            var expected4 = "Yes";
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = FileNameCheck("MY16FILE3.exe");
            var expected5 = "Yes";
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = FileNameCheck("His12FILE94.exe");
            var expected6 = "No";
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = FileNameCheck("_Y.txt");
            var expected7 = "No";
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = FileNameCheck("?aREYA.exe");
            var expected8 = "No";
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = FileNameCheck("/this_is_valid.dll");
            var expected9 = "No";
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

            var actual10 = FileNameCheck("this_is_valid.wow");
            var expected10 = "No";
            var result10 = compareLogic.Compare(actual10, expected10);
            if (!result10.AreEqual) {throw new Exception("Exception --- test case 9 failed to pass");}

            var actual11 = FileNameCheck("this_is_valid.txt");
            var expected11 = "Yes";
            var result11 = compareLogic.Compare(actual11, expected11);
            if (!result11.AreEqual) {throw new Exception("Exception --- test case 10 failed to pass");}

            var actual12 = FileNameCheck("this_is_valid.txtexe");
            var expected12 = "No";
            var result12 = compareLogic.Compare(actual12, expected12);
            if (!result12.AreEqual) {throw new Exception("Exception --- test case 11 failed to pass");}

            var actual13 = FileNameCheck("#this2_i4s_5valid.ten");
            var expected13 = "No";
            var result13 = compareLogic.Compare(actual13, expected13);
            if (!result13.AreEqual) {throw new Exception("Exception --- test case 12 failed to pass");}

            var actual14 = FileNameCheck("@this1_is6_valid.exe");
            var expected14 = "No";
            var result14 = compareLogic.Compare(actual14, expected14);
            if (!result14.AreEqual) {throw new Exception("Exception --- test case 13 failed to pass");}

            var actual15 = FileNameCheck("this_is_12valid.6exe4.txt");
            var expected15 = "No";
            var result15 = compareLogic.Compare(actual15, expected15);
            if (!result15.AreEqual) {throw new Exception("Exception --- test case 14 failed to pass");}

            var actual16 = FileNameCheck("all.exe.txt");
            var expected16 = "No";
            var result16 = compareLogic.Compare(actual16, expected16);
            if (!result16.AreEqual) {throw new Exception("Exception --- test case 15 failed to pass");}

            var actual17 = FileNameCheck("I563_No.exe");
            var expected17 = "Yes";
            var result17 = compareLogic.Compare(actual17, expected17);
            if (!result17.AreEqual) {throw new Exception("Exception --- test case 16 failed to pass");}

            var actual18 = FileNameCheck("Is3youfault.txt");
            var expected18 = "Yes";
            var result18 = compareLogic.Compare(actual18, expected18);
            if (!result18.AreEqual) {throw new Exception("Exception --- test case 17 failed to pass");}

            var actual19 = FileNameCheck("no_one#knows.dll");
            var expected19 = "Yes";
            var result19 = compareLogic.Compare(actual19, expected19);
            if (!result19.AreEqual) {throw new Exception("Exception --- test case 18 failed to pass");}

            var actual20 = FileNameCheck("1I563_Yes3.exe");
            var expected20 = "No";
            var result20 = compareLogic.Compare(actual20, expected20);
            if (!result20.AreEqual) {throw new Exception("Exception --- test case 19 failed to pass");}

            var actual21 = FileNameCheck("I563_Yes3.txtt");
            var expected21 = "No";
            var result21 = compareLogic.Compare(actual21, expected21);
            if (!result21.AreEqual) {throw new Exception("Exception --- test case 20 failed to pass");}

            var actual22 = FileNameCheck("final..txt");
            var expected22 = "No";
            var result22 = compareLogic.Compare(actual22, expected22);
            if (!result22.AreEqual) {throw new Exception("Exception --- test case 21 failed to pass");}

            var actual23 = FileNameCheck("final132");
            var expected23 = "No";
            var result23 = compareLogic.Compare(actual23, expected23);
            if (!result23.AreEqual) {throw new Exception("Exception --- test case 22 failed to pass");}

            var actual24 = FileNameCheck("_f4indsartal132.");
            var expected24 = "No";
            var result24 = compareLogic.Compare(actual24, expected24);
            if (!result24.AreEqual) {throw new Exception("Exception --- test case 23 failed to pass");}

            var actual25 = FileNameCheck(".txt");
            var expected25 = "No";
            var result25 = compareLogic.Compare(actual25, expected25);
            if (!result25.AreEqual) {throw new Exception("Exception --- test case 24 failed to pass");}

            var actual26 = FileNameCheck("s.");
            var expected26 = "No";
            var result26 = compareLogic.Compare(actual26, expected26);
            if (!result26.AreEqual) {throw new Exception("Exception --- test case 25 failed to pass");}

        }
    }
}
```
