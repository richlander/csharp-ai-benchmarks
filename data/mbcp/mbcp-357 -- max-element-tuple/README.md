# mbcp-357 -- Find the maximum element in given tuples

## Text

Write a function to find the maximum element of all the given tuple records.

## Code

```csharp
public int FindMax(List<List<int>> testList) 
{
    int res = testList.SelectMany(i => i).Max();
    return res;
}
```

## Test List

```csharp
Debug.Assert(FindMax(new (int, int)[]{(2, 4), (6, 7), (5, 1), (6, 10), (8, 7)}) == 10);
```

```csharp
Debug.Assert(FindMax(new (int, int)[] { (3, 5), (7, 8), (6, 2), (7, 11), (9, 8) }) == 11);
```

```csharp
Debug.Assert(FindMax(new (int, int)[] { (4, 6), (8, 9), (7, 3), (8, 12), (10, 9) }) == 12);
```
