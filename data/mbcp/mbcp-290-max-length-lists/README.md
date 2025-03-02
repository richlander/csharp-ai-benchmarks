# mbcp290 -- Find lists with the maximum length from input

## Text

Write a function to find the list of lists with maximum length.

## Code

```csharp
public (int, string) MaxLength(List<string> list1) 
{
    int maxLength = list1.Max(x => x.Length);
    string maxList = list1.Max();
    return (maxLength, maxList);
}
```

## Test List

```csharp
Debug.Assert(MaxLength(new List<List<int>> { new List<int> { 0 }, new List<int> { 1, 3 }, new List<int> { 5, 7 }, new List<int> { 9, 11 }, new List<int> { 13, 15, 17 } }) == (3, new List<int> { 13, 15, 17 }));
```

```csharp
Debug.Assert(MaxLength(new List<List<int>>() { new List<int>() { 1 }, new List<int>() { 5, 7 }, new List<int>() { 10, 12, 14, 15 } }) == (4, new List<int>() { 10, 12, 14, 15 }));
```

```csharp
Debug.Assert(MaxLength(new int[][] { new int[] { 5 }, new int[] { 15, 20, 25 } }) == (3, new int[] { 15, 20, 25 }));
```
