using System;
using System.Linq;
using System.Diagnostics;

int[] HeapQueueLargest(int[] nums, int n)
{
    return nums.OrderByDescending(x => x).Take(n).ToArray();
}

var test1 = HeapQueueLargest(new int[]{25, 35, 22, 85, 14, 65, 75, 22, 58}, 3);
bool test1Passed = test1.SequenceEqual(new int[]{85, 75, 65});
Console.WriteLine($"Result: ({string.Join(", ", test1)}), Expected: (85, 75, 65), Test Passed: {test1Passed}");
Debug.Assert(test1Passed);

var test2 = HeapQueueLargest(new int[]{25, 35, 22, 85, 14, 65, 75, 22, 58}, 2);
bool test2Passed = test2.SequenceEqual(new int[]{85, 75});
Console.WriteLine($"Result: ({string.Join(", ", test2)}), Expected: (85, 75), Test Passed: {test2Passed}");
Debug.Assert(test2Passed);

var test3 = HeapQueueLargest(new int[]{25, 35, 22, 85, 14, 65, 75, 22, 58}, 5);
bool test3Passed = test3.SequenceEqual(new int[]{85, 75, 65, 58, 35});
Console.WriteLine($"Result: ({string.Join(", ", test3)}), Expected: (85, 75, 65, 58, 35), Test Passed: {test3Passed}");
Debug.Assert(test3Passed);
