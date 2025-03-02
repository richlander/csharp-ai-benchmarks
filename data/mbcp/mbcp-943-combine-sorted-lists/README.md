# mbcp943 -- Combine two sorted lists using the heapq module

## Text

Write a function to combine two given sorted lists using heapq module.

## Code

```csharp
using System.Collections.Generic;
using System.Linq;

public class ListCombiner
{
    public List<int> CombineLists(List<int> num1, List<int> num2)
    {
        return num1.Concat(num2).OrderBy(x => x).ToList();
    }
}
```

## Test List

```csharp
Debug.Assert(CombineLists(new List<int> { 1, 3, 5, 7, 9, 11 }, new List<int> { 0, 2, 4, 6, 8, 10 }).SequenceEqual(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }));
```

```csharp
Debug.Assert(CombineLists(new List<int> { 1, 3, 5, 6, 8, 9 }, new List<int> { 2, 5, 7, 11 }).SequenceEqual(new List<int> { 1, 2, 3, 5, 5, 6, 7, 8, 9, 11 }));
```

```csharp
Debug.Assert(CombineLists(new List<int> { 1, 3, 7 }, new List<int> { 2, 4, 6 }).SequenceEqual(new List<int> { 1, 2, 3, 4, 6, 7 }));
```
