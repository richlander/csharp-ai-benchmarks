# mbcp859 -- Generate all sublists from a given list

## Text

Write a function to generate all sublists of a given list.

## Code

```csharp
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static List<List<T>> SubLists<T>(List<T> myList)
    {
        var subs = new List<List<T>>();
        for (int i = 0; i <= myList.Count; i++)
        {
            var temp = Combinations(myList, i);
            if (temp.Count > 0)
            {
                subs.AddRange(temp);
            }
        }
        return subs;
    }

    private static List<List<T>> Combinations<T>(List<T> list, int length)
    {
        if (length == 0) return new List<List<T>> { new List<T>() };
        if (list.Count == 0) return new List<List<T>>();

        var result = new List<List<T>>();
        foreach (var item in list)
        {
            var remaining = list.Where(x => !EqualityComparer<T>.Default.Equals(x, item)).ToList();
            var subCombinations = Combinations(remaining, length - 1);
            foreach (var combination in subCombinations)
            {
                combination.Insert(0, item);
                result.Add(combination);
            }
        }
        return result;
    }
}
```

## Test List

```csharp
Debug.Assert(SubLists(new int[] { 10, 20, 30, 40 }).SequenceEqual(new List<List<int>> {
    new List<int>(),
    new List<int> { 10 },
    new List<int> { 20 },
    new List<int> { 30 },
    new List<int> { 40 },
    new List<int> { 10, 20 },
    new List<int> { 10, 30 },
    new List<int> { 10, 40 },
    new List<int> { 20, 30 },
    new List<int> { 20, 40 },
    new List<int> { 30, 40 },
    new List<int> { 10, 20, 30 },
    new List<int> { 10, 20, 40 },
    new List<int> { 10, 30, 40 },
    new List<int> { 20, 30, 40 },
    new List<int> { 10, 20, 30, 40 }
}));
```

```csharp
Debug.Assert(SubLists(new List<string> { "X", "Y", "Z" }).SequenceEqual(new List<List<string>> { new List<string>(), new List<string> { "X" }, new List<string> { "Y" }, new List<string> { "Z" }, new List<string> { "X", "Y" }, new List<string> { "X", "Z" }, new List<string> { "Y", "Z" }, new List<string> { "X", "Y", "Z" } }));
```

```csharp
Debug.Assert(SubLists(new List<int> { 1, 2, 3 }).SequenceEqual(new List<List<int>> { new List<int>(), new List<int> { 1 }, new List<int> { 2 }, new List<int> { 3 }, new List<int> { 1, 2 }, new List<int> { 1, 3 }, new List<int> { 2, 3 }, new List<int> { 1, 2, 3 } }));
```
