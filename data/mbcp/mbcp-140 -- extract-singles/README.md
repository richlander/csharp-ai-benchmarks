# mbcp-140 -- Extract unique elements from a tuple list

## Text

Write a function to extract elements that occur singly in the given tuple list.

## Code

```csharp
public List<T> ExtractSingly<T>(List<List<T>> testList) {
    List<T> res = new List<T>();
    HashSet<T> temp = new HashSet<T>();
    foreach (var inner in testList) {
        foreach (var ele in inner) {
            if (!temp.Contains(ele)) {
                temp.Add(ele);
                res.Add(ele);
            }
        }
    }
    return res;
}
```

## Test List

```csharp
Debug.Assert(ExtractSingly(new List<Tuple<int, int, int>> { Tuple.Create(3, 4, 5), Tuple.Create(4, 5, 7), Tuple.Create(1, 4) }).SequenceEqual(new List<int> { 3, 4, 5, 7, 1 }));
```

```csharp
Debug.Assert(ExtractSingly(new Tuple<int, int, int>[] { Tuple.Create(1, 2, 3), Tuple.Create(4, 2, 3), Tuple.Create(7, 8) }).SequenceEqual(new List<int> { 1, 2, 3, 4, 7, 8 }));
```

```csharp
Debug.Assert(ExtractSingly(new List<Tuple<int, int, int>> { Tuple.Create(7, 8, 9), Tuple.Create(10, 11, 12), Tuple.Create(10, 11) }).SequenceEqual(new List<int> { 7, 8, 9, 10, 11, 12 }));
```
