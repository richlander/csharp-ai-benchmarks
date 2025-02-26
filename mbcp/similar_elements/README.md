# 2 -- Find similar elements from two tuple lists

similar_elements

## Prompt

Write a function to find the similar elements from the given two tuple lists.

## Solution

```csharp
using System;
using System.Linq;
using System.Diagnostics;

int[] SimilarElements(int[] test_tup1, int[] test_tup2)
{
    var res = test_tup1.Intersect(test_tup2).ToArray();
    Array.Sort(res);
    return res;
}
```

## Tests

```csharp
Debug.Assert(SimilarElements(new int[]{3,4,5,6}, new int[]{5,7,4,10}).SequenceEqual(new int[]{4,5}));
```

```csharp
Debug.Assert(SimilarElements(new int[]{1,2,3,4}, new int[]{5,4,3,7}).SequenceEqual(new int[]{3,4}));
```

```csharp
Debug.Assert(SimilarElements(new int[]{11,12,14,13}, new int[]{17,15,14,13}).SequenceEqual(new int[]{13,14}));
```
