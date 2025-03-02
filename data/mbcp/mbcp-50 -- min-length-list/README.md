# mbcp-50 -- Find the shortest list using a lambda function

## Text

Write a function to find the list with minimum length using lambda function.

## Code

```csharp
public (int, List<string>) MinLengthList(List<List<string>> inputList) 
{
    int minLength = inputList.Min(x => x.Count);
    List<string> minList = inputList.OrderBy(i => i.Count).First();
    return (minLength, minList);
}
```

## Test List

```csharp
Debug.Assert(MinLengthList(new List<List<int>> { new List<int> { 0 }, new List<int> { 1, 3 }, new List<int> { 5, 7 }, new List<int> { 9, 11 }, new List<int> { 13, 15, 17 } }) == (1, new List<int> { 0 }));
```

```csharp
Debug.Assert(MinLengthList(new List<List<int>> { new List<int> { 1, 2, 3, 4, 5 }, new List<int> { 1, 2, 3, 4 }, new List<int> { 1, 2, 3 }, new List<int> { 1, 2 }, new List<int> { 1 } }) == (1, new List<int> { 1 }));
```

```csharp
Debug.Assert(MinLengthList(new List<List<int>> { new List<int> { 3, 4, 5 }, new List<int> { 6, 7, 8, 9 }, new List<int> { 10, 11, 12 }, new List<int> { 1, 2 } }) == (2, new List<int> { 1, 2 }));
```
