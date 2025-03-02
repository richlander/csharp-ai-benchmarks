# mbcp-712 -- Function to eliminate duplicate nested lists

## Text

Write a function to remove duplicates from a list of lists.

## Code

```csharp
using System.Collections.Generic;
using System.Linq;

public class MyClass
{
    public List<T> RemoveDuplicate<T>(List<T> list1)
    {
        list1.Sort();
        var removeDuplicate = list1.Distinct().ToList();
        return removeDuplicate;
    }
}
```

## Test List

```csharp
Debug.Assert(RemoveDuplicate(new List<List<int>> { new List<int> { 10, 20 }, new List<int> { 40 }, new List<int> { 30, 56, 25 }, new List<int> { 10, 20 }, new List<int> { 33 }, new List<int> { 40 } }) == new List<List<int>> { new List<int> { 10, 20 }, new List<int> { 30, 56, 25 }, new List<int> { 33 }, new List<int> { 40 } });
```

```csharp
Debug.Assert(RemoveDuplicate(new string[] { "a", "b", "a", "c", "c" }).SequenceEqual(new string[] { "a", "b", "c" }));
```

```csharp
Debug.Assert(RemoveDuplicate(new List<int> { 1, 3, 5, 6, 3, 5, 6, 1 }).SequenceEqual(new List<int> { 1, 3, 5, 6 }));
```
