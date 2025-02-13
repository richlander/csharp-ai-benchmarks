# 153 -- Find strongest extension for a class

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
        /// You will be given the name of a class (a string) and a list of extensions.
        /// The extensions are to be used to load additional classes to the class. The
        /// strength of the extension is as follows: Let CAP be the number of the uppercase
        /// letters in the extension's name, and let SM be the number of lowercase letters 
        /// in the extension's name, the strength is given by the fraction CAP - SM. 
        /// You should find the strongest extension and return a string in this 
        /// format: ClassName.StrongestExtensionName.
        /// If there are two or more extensions with the same strength, you should
        /// choose the one that comes first in the list.
        /// For example, if you are given "Slices" as the class and a list of the
        /// extensions: ['SErviNGSliCes', 'Cheese', 'StuFfed'] then you should
        /// return 'Slices.SErviNGSliCes' since 'SErviNGSliCes' is the strongest extension 
        /// (its strength is -1).
        /// Example:
        /// for StrongestExtension('my_class', ['AA', 'Be', 'CC']) == 'my_class.AA'
        /// 
        /// </summary>
        public static string StrongestExtension (string class_name, List<string> extensions) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = StrongestExtension("Watashi",new List<string> {"tEN","niNE","eIGHt8OKe"});
            var expected1 = "Watashi.eIGHt8OKe";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = StrongestExtension("Boku123",new List<string> {"nani","NazeDa","YEs.WeCaNe","32145tggg"});
            var expected2 = "Boku123.YEs.WeCaNe";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = StrongestExtension("__YESIMHERE",new List<string> {"t","eMptY","nothing","zeR00","NuLl__","123NoooneB321"});
            var expected3 = "__YESIMHERE.NuLl__";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = StrongestExtension("K",new List<string> {"Ta","TAR","t234An","cosSo"});
            var expected4 = "K.TAR";
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = StrongestExtension("__HAHA",new List<string> {"Tab","123","781345","-_-"});
            var expected5 = "__HAHA.123";
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = StrongestExtension("YameRore",new List<string> {"HhAas","okIWILL123","WorkOut","Fails","-_-"});
            var expected6 = "YameRore.okIWILL123";
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = StrongestExtension("finNNalLLly",new List<string> {"Die","NowW","Wow","WoW"});
            var expected7 = "finNNalLLly.WoW";
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = StrongestExtension("_",new List<string> {"Bb","91245"});
            var expected8 = "_.Bb";
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = StrongestExtension("Sp",new List<string> {"671235","Bb"});
            var expected9 = "Sp.671235";
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

        }
    }
}
```
