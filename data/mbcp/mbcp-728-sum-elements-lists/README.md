# mbcp728 -- Sum elements from two given lists

## Text

Write a function to sum elements in two lists.

## Code

```csharp
public List<int> SumList(List<int> lst1, List<int> lst2)
{
    List<int> resList = new List<int>();
    for (int i = 0; i < lst1.Count; i++)
    {
        resList.Add(lst1[i] + lst2[i]);
    }
    return resList;
}
```

## Test List

```csharp
Debug.Assert(SumList(new int[] { 10, 20, 30 }, new int[] { 15, 25, 35 }).SequenceEqual(new int[] { 25, 45, 65 }));
```

```csharp
Debug.Assert(SumList(new int[] { 1, 2, 3 }, new int[] { 5, 6, 7 }).SequenceEqual(new int[] { 6, 8, 10 }));
```

```csharp
Debug.Assert(SumList(new int[] { 15, 20, 30 }, new int[] { 15, 45, 75 }).SequenceEqual(new int[] { 30, 65, 105 }));
```
