# mbcp39 -- Check for rearrangement of string with different adjacent letters

## Text

Write a function to check if the letters of a given string can be rearranged so that two characters that are adjacent to each other are different.

## Code

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string RearangeString(string S)
    {
        var ctr = S.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        var heap = new List<(int, char)>(ctr.Select(kvp => (-kvp.Value, kvp.Key)));
        Heapify(heap);
        if (-heap[0].Item1 * 2 > S.Length + 1)
        {
            return "";
        }
        
        var ans = new List<char>();
        while (heap.Count >= 2)
        {
            var (nct1, char1) = Pop(heap);
            var (nct2, char2) = Pop(heap);
            ans.Add(char1);
            ans.Add(char2);
            if (nct1 + 1 < 0) Push(heap, (nct1 + 1, char1));
            if (nct2 + 1 < 0) Push(heap, (nct2 + 1, char2));
        }
        
        return new string(ans.ToArray()) + (heap.Count > 0 ? heap[0].Item2.ToString() : "");
    }

    private void Heapify(List<(int, char)> heap)
    {
        // Implement min-heapify method for a tuple list
        // This is a placeholder as a full heap implementation is needed
        heap.Sort((x, y) => x.Item1.CompareTo(y.Item1));
    }

    private (int, char) Pop(List<(int, char)> heap)
    {
        var item = heap[0];
        heap.RemoveAt(0);
        return item;
    }

    private void Push(List<(int, char)> heap, (int, char) item)
    {
        heap.Add(item);
        // Re-heapify to maintain heap order
        heap.Sort((x, y) => x.Item1.CompareTo(y.Item1));
    }
}
```

## Test List

```csharp
Debug.Assert(RearangeString("aab") == "aba");
```

```csharp
Debug.Assert(RearangeString("aabb") == "abab");
```

```csharp
Debug.Assert(RearangeString("abccdd") == "cdabcd");
```
