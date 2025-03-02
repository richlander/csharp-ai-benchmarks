# mbcp872 -- Check if a nested list is a subset of another

## Text

Write a function to check if a nested list is a subset of another nested list.

## Code

```csharp
public bool CheckSubset(List<int> list1, List<int> list2) 
{ 
    return list2.All(item => list1.Contains(item)); 
}
```

## Test List

```csharp
Debug.Assert(CheckSubset(new int[][] { new int[] { 1, 3 }, new int[] { 5, 7 }, new int[] { 9, 11 }, new int[] { 13, 15, 17 } }, new int[][] { new int[] { 1, 3 }, new int[] { 13, 15, 17 } }) == true);
```

```csharp
Debug.Assert(CheckSubset(new int[][] { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 4 }, new int[] { 5, 6 } }, new int[][] { new int[] { 3, 4 }, new int[] { 5, 6 } }) == true);
```

```csharp
Debug.Assert(CheckSubset(new List<List<List<int>>> { new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 2, 3 } }, new List<List<int>> { new List<int> { 3, 4 }, new List<int> { 5, 7 } } }, new List<List<List<int>>> { new List<List<int>> { new List<int> { 3, 4 }, new List<int> { 5, 6 } } }) == false);
```
