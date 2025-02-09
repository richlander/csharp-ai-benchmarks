using System;
using System.Linq;
using System.Diagnostics;

int[] SimilarElements(int[] test_tup1, int[] test_tup2)
{
    var res = test_tup1.Intersect(test_tup2).ToArray();
    Array.Sort(res);
    return res;
}

var test1 = SimilarElements(new int[]{3, 4, 5, 6}, new int[]{5, 7, 4, 10});
bool test1Passed = test1.SequenceEqual(new int[]{4, 5});
Console.WriteLine($"Result: ({string.Join(", ", test1)}), Expected: (4, 5), Test Passed: {test1Passed}");
Debug.Assert(test1Passed);

var test2 = SimilarElements(new int[]{1, 2, 3, 4}, new int[]{5, 4, 3, 7});
bool test2Passed = test2.SequenceEqual(new int[]{3, 4});
Console.WriteLine($"Result: ({string.Join(", ", test2)}), Expected: (3, 4), Test Passed: {test2Passed}");
Debug.Assert(test2Passed);

var test3 = SimilarElements(new int[]{11, 12, 14, 13}, new int[]{17, 15, 14, 13});
bool test3Passed = test3.SequenceEqual(new int[]{13, 14});
Console.WriteLine($"Result: ({string.Join(", ", test3)}), Expected: (13, 14), Test Passed: {test3Passed}");
Debug.Assert(test3Passed);
