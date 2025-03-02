# mbcp-216 -- Check if one nested list is a subset of another

## Text

Write a function to check if a nested list is a subset of another nested list.

## Code

```csharp
public bool CheckSubsetList(List<int> list1, List<int> list2) 
{
    var l1 = list1[0];
    var l2 = list2[0];
    bool exist = true;

    foreach (var i in list2) 
    {
        if (!list1.Contains(i)) 
        {
            exist = false;
        }
    }
    return exist;
}
```

## Test List

```csharp
Debug.Assert(CheckSubsetList(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, new List<List<int>> { new List<int> { 12, 18, 23, 25, 45 }, new List<int> { 7, 11, 19, 24, 28 }, new List<int> { 1, 5, 8, 18, 15, 16 } }) == false);
```

```csharp
Debug.Assert(CheckSubsetList(new int[][] { new int[] { 2, 3, 1 }, new int[] { 4, 5 }, new int[] { 6, 8 } }, new int[][] { new int[] { 4, 5 }, new int[] { 6, 8 } }) == true);
```

```csharp
Debug.Assert(CheckSubsetList(new List<List<string>> { new List<string> { "a", "b" }, new List<string> { "e" }, new List<string> { "c", "d" } }, new List<List<string>> { new List<string> { "g" } }) == false);
```
