# mbcp393 -- Find longest list using a lambda function

## Text

Write a function to find the list with maximum length using lambda function.

## Code

```csharp
public (int, string) MaxLengthList(List<string> inputList) 
{
    int maxLength = inputList.Max(x => x.Length);
    string maxList = inputList.OrderByDescending(i => i.Length).First();
    return (maxLength, maxList);
}
```

## Test List

```csharp
Debug.Assert(MaxLengthList(new List<List<int>> { new List<int> { 0 }, new List<int> { 1, 3 }, new List<int> { 5, 7 }, new List<int> { 9, 11 }, new List<int> { 13, 15, 17 } }) == (3, new List<int> { 13, 15, 17 }));
```

```csharp
Debug.Assert(MaxLengthList(new List<List<int>> { new List<int> { 1, 2, 3, 4, 5 }, new List<int> { 1, 2, 3, 4 }, new List<int> { 1, 2, 3 }, new List<int> { 1, 2 }, new List<int> { 1 } }) == (5, new List<int> { 1, 2, 3, 4, 5 }));
```

```csharp
Debug.Assert(MaxLengthList(new List<List<int>> { new List<int> { 3, 4, 5 }, new List<int> { 6, 7, 8, 9 }, new List<int> { 10, 11, 12 } }) == (4, new List<int> { 6, 7, 8, 9 }));
```
