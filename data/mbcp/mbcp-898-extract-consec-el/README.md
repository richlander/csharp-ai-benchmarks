# mbcp898 -- Extract consecutive elements from a list

## Text

Write a function to extract specified number of elements from a given list, which follow each other continuously.

## Code

```csharp
using System.Collections.Generic;
using System.Linq;

public class MyClass
{
    public List<int> ExtractElements(List<int> numbers, int n)
    {
        return numbers.GroupBy(i => i)
                      .Where(g => g.Count() == n)
                      .Select(g => g.Key)
                      .ToList();
    }
}
```

## Test List

```csharp
Debug.Assert(ExtractElements(new List<int> { 1, 1, 3, 4, 4, 5, 6, 7 }, 2).SequenceEqual(new List<int> { 1, 4 }));
```

```csharp
Debug.Assert(ExtractElements(new int[] { 0, 1, 2, 3, 4, 4, 4, 4, 5, 7 }, 4).SequenceEqual(new int[] { 4 }));
```

```csharp
Debug.Assert(ExtractElements(new int[] { 0, 0, 0, 0, 0 }, 5).SequenceEqual(new int[] { 0 }));
```
