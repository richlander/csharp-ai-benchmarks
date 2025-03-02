# mbcp363 -- Add k to each element in a tuple

## Text

Write a function to add the k elements to each element in the tuple.

## Code

```csharp
public List<Tuple<int, int>> AddKElement(List<List<int>> testList, int K) 
{
    var res = testList.Select(sub => sub.Select(j => j + K).ToArray()).Select(arr => Tuple.Create(arr[0], arr[1])).ToList();
    return res;
}
```

## Test List

```csharp
Debug.Assert(AddKElement(new List<(int, int, int)> { (1, 3, 4), (2, 4, 6), (3, 8, 1) }, 4).SequenceEqual(new List<(int, int, int)> { (5, 7, 8), (6, 8, 10), (7, 12, 5) }));
```

```csharp
Debug.Assert(AddKElement(new List<(int, int, int)> { (1, 2, 3), (4, 5, 6), (7, 8, 9) }, 8).SequenceEqual(new List<(int, int, int)> { (9, 10, 11), (12, 13, 14), (15, 16, 17) }));
```

```csharp
Debug.Assert(AddKElement(new Tuple<int, int, int>[] { Tuple.Create(11, 12, 13), Tuple.Create(14, 15, 16), Tuple.Create(17, 18, 19) }, 9).SequenceEqual(new Tuple<int, int, int>[] { Tuple.Create(20, 21, 22), Tuple.Create(23, 24, 25), Tuple.Create(26, 27, 28) }));
```
