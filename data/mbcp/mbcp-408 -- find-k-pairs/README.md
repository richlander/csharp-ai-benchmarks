# mbcp-408 -- Find k pairs from two arrays of elements

## Text

Write a function to find k number of pairs which consist of one element from the first array and one element from the second array.

## Code

```csharp
using System;
using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k) {
        var queue = new SortedSet<(int sum, int i, int j)>();
        void Push(int i, int j) {
            if (i < nums1.Length && j < nums2.Length) {
                queue.Add((nums1[i] + nums2[j], i, j));
            }
        }
        
        Push(0, 0);
        var pairs = new List<IList<int>>();
        
        while (queue.Count > 0 && pairs.Count < k) {
            var (sum, i, j) = queue.Min;
            queue.Remove(queue.Min);
            pairs.Add(new List<int> { nums1[i], nums2[j] });
            Push(i, j + 1);
            if (j == 0) {
                Push(i + 1, 0);
            }
        }
        
        return pairs;
    }
}
```

## Test List

```csharp
Debug.Assert(Push(new int[] { 1, 3, 7 }, new int[] { 2, 4, 6 }, 2).SequenceEqual(new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 1, 4 } }));
```

```csharp
Debug.Assert(Push(new int[] { 1, 3, 7 }, new int[] { 2, 4, 6 }, 1).SequenceEqual(new int[][] { new int[] { 1, 2 } }));
```

```csharp
Debug.Assert(Push(new int[] { 1, 3, 7 }, new int[] { 2, 4, 6 }, 7).SequenceEqual(new List<int[]> { new int[] { 1, 2 }, new int[] { 1, 4 }, new int[] { 3, 2 }, new int[] { 1, 6 }, new int[] { 3, 4 }, new int[] { 3, 6 }, new int[] { 7, 2 } }));
```
