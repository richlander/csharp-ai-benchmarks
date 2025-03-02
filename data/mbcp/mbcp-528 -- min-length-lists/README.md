# mbcp-528 -- Find lists with the minimum length from input

## Text

Write a function to find the list of lists with minimum length.

## Code

```csharp
public (int, string) MinLength(List<string> list1)
{
    int minLength = list1.Min(x => x.Length);
    string minList = list1.OrderBy(x => x.Length).First();
    return (minLength, minList);
}
```

## Test List

```csharp
Debug.Assert(MinLength(new List<List<int>> { new List<int> { 0 }, new List<int> { 1, 3 }, new List<int> { 5, 7 }, new List<int> { 9, 11 }, new List<int> { 13, 15, 17 } }) == (1, new List<int> { 0 }));
```

```csharp
Debug.Assert(MinLength(new List<List<int>> { new List<int> { 1 }, new List<int> { 5, 7 }, new List<int> { 10, 12, 14, 15 } }) == (1, new List<int> { 1 }));
```

```csharp
Debug.Assert(MinLength(new List<List<int>> { new List<int> { 5 }, new List<int> { 15, 20, 25 } }) == (1, new List<int> { 5 }));
```
