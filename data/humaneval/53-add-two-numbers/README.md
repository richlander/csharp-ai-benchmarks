
# 53 -- Add two numbers using the add function

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
        /// Add two numbers x and y
        /// >>> Add(2, 3)
        /// 5
        /// >>> Add(5, 7)
        /// 12
        /// 
        /// </summary>
        public static int Add (int x, int y) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Add(0,1);
            var expected1 = 1;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Add(1,0);
            var expected2 = 1;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Add(2,3);
            var expected3 = 5;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = Add(5,7);
            var expected4 = 12;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = Add(7,5);
            var expected5 = 12;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = Add(572,725);
            var expected6 = 1297;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = Add(51,804);
            var expected7 = 855;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = Add(645,96);
            var expected8 = 741;
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = Add(712,853);
            var expected9 = 1565;
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

            var actual10 = Add(223,101);
            var expected10 = 324;
            var result10 = compareLogic.Compare(actual10, expected10);
            if (!result10.AreEqual) {throw new Exception("Exception --- test case 9 failed to pass");}

            var actual11 = Add(76,29);
            var expected11 = 105;
            var result11 = compareLogic.Compare(actual11, expected11);
            if (!result11.AreEqual) {throw new Exception("Exception --- test case 10 failed to pass");}

            var actual12 = Add(416,149);
            var expected12 = 565;
            var result12 = compareLogic.Compare(actual12, expected12);
            if (!result12.AreEqual) {throw new Exception("Exception --- test case 11 failed to pass");}

            var actual13 = Add(145,409);
            var expected13 = 554;
            var result13 = compareLogic.Compare(actual13, expected13);
            if (!result13.AreEqual) {throw new Exception("Exception --- test case 12 failed to pass");}

            var actual14 = Add(535,430);
            var expected14 = 965;
            var result14 = compareLogic.Compare(actual14, expected14);
            if (!result14.AreEqual) {throw new Exception("Exception --- test case 13 failed to pass");}

            var actual15 = Add(118,303);
            var expected15 = 421;
            var result15 = compareLogic.Compare(actual15, expected15);
            if (!result15.AreEqual) {throw new Exception("Exception --- test case 14 failed to pass");}

            var actual16 = Add(287,94);
            var expected16 = 381;
            var result16 = compareLogic.Compare(actual16, expected16);
            if (!result16.AreEqual) {throw new Exception("Exception --- test case 15 failed to pass");}

            var actual17 = Add(768,257);
            var expected17 = 1025;
            var result17 = compareLogic.Compare(actual17, expected17);
            if (!result17.AreEqual) {throw new Exception("Exception --- test case 16 failed to pass");}

            var actual18 = Add(421,677);
            var expected18 = 1098;
            var result18 = compareLogic.Compare(actual18, expected18);
            if (!result18.AreEqual) {throw new Exception("Exception --- test case 17 failed to pass");}

            var actual19 = Add(802,814);
            var expected19 = 1616;
            var result19 = compareLogic.Compare(actual19, expected19);
            if (!result19.AreEqual) {throw new Exception("Exception --- test case 18 failed to pass");}

            var actual20 = Add(510,922);
            var expected20 = 1432;
            var result20 = compareLogic.Compare(actual20, expected20);
            if (!result20.AreEqual) {throw new Exception("Exception --- test case 19 failed to pass");}

            var actual21 = Add(345,819);
            var expected21 = 1164;
            var result21 = compareLogic.Compare(actual21, expected21);
            if (!result21.AreEqual) {throw new Exception("Exception --- test case 20 failed to pass");}

            var actual22 = Add(895,436);
            var expected22 = 1331;
            var result22 = compareLogic.Compare(actual22, expected22);
            if (!result22.AreEqual) {throw new Exception("Exception --- test case 21 failed to pass");}

            var actual23 = Add(123,424);
            var expected23 = 547;
            var result23 = compareLogic.Compare(actual23, expected23);
            if (!result23.AreEqual) {throw new Exception("Exception --- test case 22 failed to pass");}

            var actual24 = Add(923,245);
            var expected24 = 1168;
            var result24 = compareLogic.Compare(actual24, expected24);
            if (!result24.AreEqual) {throw new Exception("Exception --- test case 23 failed to pass");}

            var actual25 = Add(23,438);
            var expected25 = 461;
            var result25 = compareLogic.Compare(actual25, expected25);
            if (!result25.AreEqual) {throw new Exception("Exception --- test case 24 failed to pass");}

            var actual26 = Add(565,133);
            var expected26 = 698;
            var result26 = compareLogic.Compare(actual26, expected26);
            if (!result26.AreEqual) {throw new Exception("Exception --- test case 25 failed to pass");}

            var actual27 = Add(945,925);
            var expected27 = 1870;
            var result27 = compareLogic.Compare(actual27, expected27);
            if (!result27.AreEqual) {throw new Exception("Exception --- test case 26 failed to pass");}

            var actual28 = Add(261,983);
            var expected28 = 1244;
            var result28 = compareLogic.Compare(actual28, expected28);
            if (!result28.AreEqual) {throw new Exception("Exception --- test case 27 failed to pass");}

            var actual29 = Add(139,577);
            var expected29 = 716;
            var result29 = compareLogic.Compare(actual29, expected29);
            if (!result29.AreEqual) {throw new Exception("Exception --- test case 28 failed to pass");}

            var actual30 = Add(763,178);
            var expected30 = 941;
            var result30 = compareLogic.Compare(actual30, expected30);
            if (!result30.AreEqual) {throw new Exception("Exception --- test case 29 failed to pass");}

            var actual31 = Add(147,892);
            var expected31 = 1039;
            var result31 = compareLogic.Compare(actual31, expected31);
            if (!result31.AreEqual) {throw new Exception("Exception --- test case 30 failed to pass");}

            var actual32 = Add(436,402);
            var expected32 = 838;
            var result32 = compareLogic.Compare(actual32, expected32);
            if (!result32.AreEqual) {throw new Exception("Exception --- test case 31 failed to pass");}

            var actual33 = Add(610,581);
            var expected33 = 1191;
            var result33 = compareLogic.Compare(actual33, expected33);
            if (!result33.AreEqual) {throw new Exception("Exception --- test case 32 failed to pass");}

            var actual34 = Add(103,416);
            var expected34 = 519;
            var result34 = compareLogic.Compare(actual34, expected34);
            if (!result34.AreEqual) {throw new Exception("Exception --- test case 33 failed to pass");}

            var actual35 = Add(339,990);
            var expected35 = 1329;
            var result35 = compareLogic.Compare(actual35, expected35);
            if (!result35.AreEqual) {throw new Exception("Exception --- test case 34 failed to pass");}

            var actual36 = Add(130,504);
            var expected36 = 634;
            var result36 = compareLogic.Compare(actual36, expected36);
            if (!result36.AreEqual) {throw new Exception("Exception --- test case 35 failed to pass");}

            var actual37 = Add(242,717);
            var expected37 = 959;
            var result37 = compareLogic.Compare(actual37, expected37);
            if (!result37.AreEqual) {throw new Exception("Exception --- test case 36 failed to pass");}

            var actual38 = Add(562,110);
            var expected38 = 672;
            var result38 = compareLogic.Compare(actual38, expected38);
            if (!result38.AreEqual) {throw new Exception("Exception --- test case 37 failed to pass");}

            var actual39 = Add(396,909);
            var expected39 = 1305;
            var result39 = compareLogic.Compare(actual39, expected39);
            if (!result39.AreEqual) {throw new Exception("Exception --- test case 38 failed to pass");}

            var actual40 = Add(887,703);
            var expected40 = 1590;
            var result40 = compareLogic.Compare(actual40, expected40);
            if (!result40.AreEqual) {throw new Exception("Exception --- test case 39 failed to pass");}

            var actual41 = Add(870,551);
            var expected41 = 1421;
            var result41 = compareLogic.Compare(actual41, expected41);
            if (!result41.AreEqual) {throw new Exception("Exception --- test case 40 failed to pass");}

            var actual42 = Add(422,391);
            var expected42 = 813;
            var result42 = compareLogic.Compare(actual42, expected42);
            if (!result42.AreEqual) {throw new Exception("Exception --- test case 41 failed to pass");}

            var actual43 = Add(299,505);
            var expected43 = 804;
            var result43 = compareLogic.Compare(actual43, expected43);
            if (!result43.AreEqual) {throw new Exception("Exception --- test case 42 failed to pass");}

            var actual44 = Add(346,56);
            var expected44 = 402;
            var result44 = compareLogic.Compare(actual44, expected44);
            if (!result44.AreEqual) {throw new Exception("Exception --- test case 43 failed to pass");}

            var actual45 = Add(36,706);
            var expected45 = 742;
            var result45 = compareLogic.Compare(actual45, expected45);
            if (!result45.AreEqual) {throw new Exception("Exception --- test case 44 failed to pass");}

            var actual46 = Add(738,411);
            var expected46 = 1149;
            var result46 = compareLogic.Compare(actual46, expected46);
            if (!result46.AreEqual) {throw new Exception("Exception --- test case 45 failed to pass");}

            var actual47 = Add(679,87);
            var expected47 = 766;
            var result47 = compareLogic.Compare(actual47, expected47);
            if (!result47.AreEqual) {throw new Exception("Exception --- test case 46 failed to pass");}

            var actual48 = Add(25,303);
            var expected48 = 328;
            var result48 = compareLogic.Compare(actual48, expected48);
            if (!result48.AreEqual) {throw new Exception("Exception --- test case 47 failed to pass");}

            var actual49 = Add(161,612);
            var expected49 = 773;
            var result49 = compareLogic.Compare(actual49, expected49);
            if (!result49.AreEqual) {throw new Exception("Exception --- test case 48 failed to pass");}

            var actual50 = Add(306,841);
            var expected50 = 1147;
            var result50 = compareLogic.Compare(actual50, expected50);
            if (!result50.AreEqual) {throw new Exception("Exception --- test case 49 failed to pass");}

            var actual51 = Add(973,411);
            var expected51 = 1384;
            var result51 = compareLogic.Compare(actual51, expected51);
            if (!result51.AreEqual) {throw new Exception("Exception --- test case 50 failed to pass");}

            var actual52 = Add(711,157);
            var expected52 = 868;
            var result52 = compareLogic.Compare(actual52, expected52);
            if (!result52.AreEqual) {throw new Exception("Exception --- test case 51 failed to pass");}

            var actual53 = Add(471,27);
            var expected53 = 498;
            var result53 = compareLogic.Compare(actual53, expected53);
            if (!result53.AreEqual) {throw new Exception("Exception --- test case 52 failed to pass");}

            var actual54 = Add(714,792);
            var expected54 = 1506;
            var result54 = compareLogic.Compare(actual54, expected54);
            if (!result54.AreEqual) {throw new Exception("Exception --- test case 53 failed to pass");}

            var actual55 = Add(38,206);
            var expected55 = 244;
            var result55 = compareLogic.Compare(actual55, expected55);
            if (!result55.AreEqual) {throw new Exception("Exception --- test case 54 failed to pass");}

            var actual56 = Add(907,343);
            var expected56 = 1250;
            var result56 = compareLogic.Compare(actual56, expected56);
            if (!result56.AreEqual) {throw new Exception("Exception --- test case 55 failed to pass");}

            var actual57 = Add(23,760);
            var expected57 = 783;
            var result57 = compareLogic.Compare(actual57, expected57);
            if (!result57.AreEqual) {throw new Exception("Exception --- test case 56 failed to pass");}

            var actual58 = Add(524,859);
            var expected58 = 1383;
            var result58 = compareLogic.Compare(actual58, expected58);
            if (!result58.AreEqual) {throw new Exception("Exception --- test case 57 failed to pass");}

            var actual59 = Add(30,529);
            var expected59 = 559;
            var result59 = compareLogic.Compare(actual59, expected59);
            if (!result59.AreEqual) {throw new Exception("Exception --- test case 58 failed to pass");}

            var actual60 = Add(341,691);
            var expected60 = 1032;
            var result60 = compareLogic.Compare(actual60, expected60);
            if (!result60.AreEqual) {throw new Exception("Exception --- test case 59 failed to pass");}

            var actual61 = Add(167,729);
            var expected61 = 896;
            var result61 = compareLogic.Compare(actual61, expected61);
            if (!result61.AreEqual) {throw new Exception("Exception --- test case 60 failed to pass");}

            var actual62 = Add(636,289);
            var expected62 = 925;
            var result62 = compareLogic.Compare(actual62, expected62);
            if (!result62.AreEqual) {throw new Exception("Exception --- test case 61 failed to pass");}

            var actual63 = Add(503,144);
            var expected63 = 647;
            var result63 = compareLogic.Compare(actual63, expected63);
            if (!result63.AreEqual) {throw new Exception("Exception --- test case 62 failed to pass");}

            var actual64 = Add(51,985);
            var expected64 = 1036;
            var result64 = compareLogic.Compare(actual64, expected64);
            if (!result64.AreEqual) {throw new Exception("Exception --- test case 63 failed to pass");}

            var actual65 = Add(287,149);
            var expected65 = 436;
            var result65 = compareLogic.Compare(actual65, expected65);
            if (!result65.AreEqual) {throw new Exception("Exception --- test case 64 failed to pass");}

            var actual66 = Add(659,75);
            var expected66 = 734;
            var result66 = compareLogic.Compare(actual66, expected66);
            if (!result66.AreEqual) {throw new Exception("Exception --- test case 65 failed to pass");}

            var actual67 = Add(462,797);
            var expected67 = 1259;
            var result67 = compareLogic.Compare(actual67, expected67);
            if (!result67.AreEqual) {throw new Exception("Exception --- test case 66 failed to pass");}

            var actual68 = Add(406,141);
            var expected68 = 547;
            var result68 = compareLogic.Compare(actual68, expected68);
            if (!result68.AreEqual) {throw new Exception("Exception --- test case 67 failed to pass");}

            var actual69 = Add(106,44);
            var expected69 = 150;
            var result69 = compareLogic.Compare(actual69, expected69);
            if (!result69.AreEqual) {throw new Exception("Exception --- test case 68 failed to pass");}

            var actual70 = Add(300,934);
            var expected70 = 1234;
            var result70 = compareLogic.Compare(actual70, expected70);
            if (!result70.AreEqual) {throw new Exception("Exception --- test case 69 failed to pass");}

            var actual71 = Add(471,524);
            var expected71 = 995;
            var result71 = compareLogic.Compare(actual71, expected71);
            if (!result71.AreEqual) {throw new Exception("Exception --- test case 70 failed to pass");}

            var actual72 = Add(122,429);
            var expected72 = 551;
            var result72 = compareLogic.Compare(actual72, expected72);
            if (!result72.AreEqual) {throw new Exception("Exception --- test case 71 failed to pass");}

            var actual73 = Add(735,195);
            var expected73 = 930;
            var result73 = compareLogic.Compare(actual73, expected73);
            if (!result73.AreEqual) {throw new Exception("Exception --- test case 72 failed to pass");}

            var actual74 = Add(335,484);
            var expected74 = 819;
            var result74 = compareLogic.Compare(actual74, expected74);
            if (!result74.AreEqual) {throw new Exception("Exception --- test case 73 failed to pass");}

            var actual75 = Add(28,809);
            var expected75 = 837;
            var result75 = compareLogic.Compare(actual75, expected75);
            if (!result75.AreEqual) {throw new Exception("Exception --- test case 74 failed to pass");}

            var actual76 = Add(430,20);
            var expected76 = 450;
            var result76 = compareLogic.Compare(actual76, expected76);
            if (!result76.AreEqual) {throw new Exception("Exception --- test case 75 failed to pass");}

            var actual77 = Add(916,635);
            var expected77 = 1551;
            var result77 = compareLogic.Compare(actual77, expected77);
            if (!result77.AreEqual) {throw new Exception("Exception --- test case 76 failed to pass");}

            var actual78 = Add(301,999);
            var expected78 = 1300;
            var result78 = compareLogic.Compare(actual78, expected78);
            if (!result78.AreEqual) {throw new Exception("Exception --- test case 77 failed to pass");}

            var actual79 = Add(454,466);
            var expected79 = 920;
            var result79 = compareLogic.Compare(actual79, expected79);
            if (!result79.AreEqual) {throw new Exception("Exception --- test case 78 failed to pass");}

            var actual80 = Add(905,259);
            var expected80 = 1164;
            var result80 = compareLogic.Compare(actual80, expected80);
            if (!result80.AreEqual) {throw new Exception("Exception --- test case 79 failed to pass");}

            var actual81 = Add(168,205);
            var expected81 = 373;
            var result81 = compareLogic.Compare(actual81, expected81);
            if (!result81.AreEqual) {throw new Exception("Exception --- test case 80 failed to pass");}

            var actual82 = Add(570,434);
            var expected82 = 1004;
            var result82 = compareLogic.Compare(actual82, expected82);
            if (!result82.AreEqual) {throw new Exception("Exception --- test case 81 failed to pass");}

            var actual83 = Add(64,959);
            var expected83 = 1023;
            var result83 = compareLogic.Compare(actual83, expected83);
            if (!result83.AreEqual) {throw new Exception("Exception --- test case 82 failed to pass");}

            var actual84 = Add(957,510);
            var expected84 = 1467;
            var result84 = compareLogic.Compare(actual84, expected84);
            if (!result84.AreEqual) {throw new Exception("Exception --- test case 83 failed to pass");}

            var actual85 = Add(722,598);
            var expected85 = 1320;
            var result85 = compareLogic.Compare(actual85, expected85);
            if (!result85.AreEqual) {throw new Exception("Exception --- test case 84 failed to pass");}

            var actual86 = Add(770,226);
            var expected86 = 996;
            var result86 = compareLogic.Compare(actual86, expected86);
            if (!result86.AreEqual) {throw new Exception("Exception --- test case 85 failed to pass");}

            var actual87 = Add(579,66);
            var expected87 = 645;
            var result87 = compareLogic.Compare(actual87, expected87);
            if (!result87.AreEqual) {throw new Exception("Exception --- test case 86 failed to pass");}

            var actual88 = Add(117,674);
            var expected88 = 791;
            var result88 = compareLogic.Compare(actual88, expected88);
            if (!result88.AreEqual) {throw new Exception("Exception --- test case 87 failed to pass");}

            var actual89 = Add(530,30);
            var expected89 = 560;
            var result89 = compareLogic.Compare(actual89, expected89);
            if (!result89.AreEqual) {throw new Exception("Exception --- test case 88 failed to pass");}

            var actual90 = Add(776,345);
            var expected90 = 1121;
            var result90 = compareLogic.Compare(actual90, expected90);
            if (!result90.AreEqual) {throw new Exception("Exception --- test case 89 failed to pass");}

            var actual91 = Add(327,389);
            var expected91 = 716;
            var result91 = compareLogic.Compare(actual91, expected91);
            if (!result91.AreEqual) {throw new Exception("Exception --- test case 90 failed to pass");}

            var actual92 = Add(596,12);
            var expected92 = 608;
            var result92 = compareLogic.Compare(actual92, expected92);
            if (!result92.AreEqual) {throw new Exception("Exception --- test case 91 failed to pass");}

            var actual93 = Add(599,511);
            var expected93 = 1110;
            var result93 = compareLogic.Compare(actual93, expected93);
            if (!result93.AreEqual) {throw new Exception("Exception --- test case 92 failed to pass");}

            var actual94 = Add(936,476);
            var expected94 = 1412;
            var result94 = compareLogic.Compare(actual94, expected94);
            if (!result94.AreEqual) {throw new Exception("Exception --- test case 93 failed to pass");}

            var actual95 = Add(461,14);
            var expected95 = 475;
            var result95 = compareLogic.Compare(actual95, expected95);
            if (!result95.AreEqual) {throw new Exception("Exception --- test case 94 failed to pass");}

            var actual96 = Add(966,157);
            var expected96 = 1123;
            var result96 = compareLogic.Compare(actual96, expected96);
            if (!result96.AreEqual) {throw new Exception("Exception --- test case 95 failed to pass");}

            var actual97 = Add(326,91);
            var expected97 = 417;
            var result97 = compareLogic.Compare(actual97, expected97);
            if (!result97.AreEqual) {throw new Exception("Exception --- test case 96 failed to pass");}

            var actual98 = Add(392,455);
            var expected98 = 847;
            var result98 = compareLogic.Compare(actual98, expected98);
            if (!result98.AreEqual) {throw new Exception("Exception --- test case 97 failed to pass");}

            var actual99 = Add(446,477);
            var expected99 = 923;
            var result99 = compareLogic.Compare(actual99, expected99);
            if (!result99.AreEqual) {throw new Exception("Exception --- test case 98 failed to pass");}

            var actual100 = Add(324,860);
            var expected100 = 1184;
            var result100 = compareLogic.Compare(actual100, expected100);
            if (!result100.AreEqual) {throw new Exception("Exception --- test case 99 failed to pass");}

            var actual101 = Add(945,85);
            var expected101 = 1030;
            var result101 = compareLogic.Compare(actual101, expected101);
            if (!result101.AreEqual) {throw new Exception("Exception --- test case 100 failed to pass");}

            var actual102 = Add(886,582);
            var expected102 = 1468;
            var result102 = compareLogic.Compare(actual102, expected102);
            if (!result102.AreEqual) {throw new Exception("Exception --- test case 101 failed to pass");}

            var actual103 = Add(886,712);
            var expected103 = 1598;
            var result103 = compareLogic.Compare(actual103, expected103);
            if (!result103.AreEqual) {throw new Exception("Exception --- test case 102 failed to pass");}

            var actual104 = Add(842,953);
            var expected104 = 1795;
            var result104 = compareLogic.Compare(actual104, expected104);
            if (!result104.AreEqual) {throw new Exception("Exception --- test case 103 failed to pass");}

        }
    }
}
```
