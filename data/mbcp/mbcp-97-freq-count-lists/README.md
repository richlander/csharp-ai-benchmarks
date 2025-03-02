# mbcp97 -- Count frequency of elements in a list of lists

## Text

Write a function to find frequency count of list of lists.

## Code

```csharp
public Dictionary<int, int> FrequencyLists(List<List<int>> list1) 
{
    list1 = list1.SelectMany(sublist => sublist).ToList();
    Dictionary<int, int> dicData = new Dictionary<int, int>();
    foreach (int num in list1) 
    {
        if (dicData.ContainsKey(num)) 
        {
            dicData[num] += 1;
        } 
        else 
        {
            dicData[num] = 1;
        }
    }
    return dicData;
}
```

## Test List

```csharp
Debug.Assert(FrequencyLists(new List<List<int>> { new List<int> { 1, 2, 3, 2 }, new List<int> { 4, 5, 6, 2 }, new List<int> { 7, 8, 9, 5 } }).SequenceEqual(new Dictionary<int, int> { { 1, 1 }, { 2, 3 }, { 3, 1 }, { 4, 1 }, { 5, 2 }, { 6, 1 }, { 7, 1 }, { 8, 1 }, { 9, 1 } }));
```

```csharp
Debug.Assert(FrequencyLists(new int[][] { new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8 }, new int[] { 9, 10, 11, 12 } }).SequenceEqual(new Dictionary<int, int> { { 1, 1 }, { 2, 1 }, { 3, 1 }, { 4, 1 }, { 5, 1 }, { 6, 1 }, { 7, 1 }, { 8, 1 }, { 9, 1 }, { 10, 1 }, { 11, 1 }, { 12, 1 } }));
```

```csharp
Debug.Assert(FrequencyLists(new List<List<int>> { new List<int> { 20, 30, 40, 17 }, new List<int> { 18, 16, 14, 13 }, new List<int> { 10, 20, 30, 40 } }) .SequenceEqual(new Dictionary<int, int> { { 20, 2 }, { 30, 2 }, { 40, 2 }, { 17, 1 }, { 18, 1 }, { 16, 1 }, { 14, 1 }, { 13, 1 }, { 10, 1 } }));
```
