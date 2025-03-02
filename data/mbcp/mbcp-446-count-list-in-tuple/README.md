# mbcp446 -- Count list elements occurring in a tuple

## Text

Write a C# function to count the occurence of all elements of list in a tuple.

## Code

```csharp
using System.Collections.Generic;

public class Solution
{
    public int CountOccurrence(Tuple<int, int>[] tup, List<int> lst)
    {
        int count = 0;
        foreach (var item in tup)
        {
            if (lst.Contains(item.Item1) || lst.Contains(item.Item2))
            {
                count++;
            }
        }
        return count;
    }
}
```

## Test List

```csharp
Debug.Assert(CountOccurrence(new[] { 'a', 'a', 'c', 'b', 'd' }, new[] { 'a', 'b' }) == 3);
```

```csharp
Debug.Assert(CountOccurrence(new int[] { 1, 2, 3, 1, 4, 6, 7, 1, 4 }, new int[] { 1, 4, 7 }) == 6);
```

```csharp
Debug.Assert(CountOccurrence(new int[] { 1, 2, 3, 4, 5, 6 }, new List<int> { 1, 2 }) == 2);
```
