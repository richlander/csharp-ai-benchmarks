# mbcp413 -- Extract nth element from a list of tuples

## Text

Write a function to extract the nth element from a given list of tuples.

## Code

```csharp
public List<T> ExtractNthElement<T>(List<List<T>> list1, int n)
{
    return list1.Select(x => x[n]).ToList();
}
```

## Test List

```csharp
Debug.Assert(ExtractNthElement(new Tuple<string, int, int>[] { Tuple.Create("Greyson Fulton", 98, 99), Tuple.Create("Brady Kent", 97, 96), Tuple.Create("Wyatt Knott", 91, 94), Tuple.Create("Beau Turnbull", 94, 98) }, 0).SequenceEqual(new List<string> { "Greyson Fulton", "Brady Kent", "Wyatt Knott", "Beau Turnbull" }));
```

```csharp
Debug.Assert(ExtractNthElement(new[] { ("Greyson Fulton", 98, 99), ("Brady Kent", 97, 96), ("Wyatt Knott", 91, 94), ("Beau Turnbull", 94, 98) }, 2).SequenceEqual(new[] { 99, 96, 94, 98 }));
```

```csharp
Debug.Assert(ExtractNthElement(new Tuple<string, int, int>[] { 
    Tuple.Create("Greyson Fulton", 98, 99), 
    Tuple.Create("Brady Kent", 97, 96), 
    Tuple.Create("Wyatt Knott", 91, 94), 
    Tuple.Create("Beau Turnbull", 94, 98) }, 1).SequenceEqual(new int[] { 98, 97, 91, 94 }));
```
