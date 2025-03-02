# mbcp152 -- Sort an array using the merge sort algorithm

## Text

Write a function to sort the given array by using merge sort.

## Code

```csharp
public List<int> Merge(List<int> a, List<int> b) {
    List<int> c = new List<int>();
    while (a.Count != 0 && b.Count != 0) {
        if (a[0] < b[0]) {
            c.Add(a[0]);
            a.RemoveAt(0);
        } else {
            c.Add(b[0]);
            b.RemoveAt(0);
        }
    }
    if (a.Count == 0) {
        c.AddRange(b);
    } else {
        c.AddRange(a);
    }
    return c;
}

public List<int> MergeSort(List<int> x) {
    if (x.Count == 0 || x.Count == 1) {
        return x;
    } else {
        int middle = x.Count / 2;
        List<int> a = MergeSort(x.GetRange(0, middle));
        List<int> b = MergeSort(x.GetRange(middle, x.Count - middle));
        return Merge(a, b);
    }
}
```

## Test List

```csharp
Debug.Assert(MergeSort(new int[] { 3, 4, 2, 6, 5, 7, 1, 9 }).SequenceEqual(new int[] { 1, 2, 3, 4, 5, 6, 7, 9 }));
```

```csharp
Debug.Assert(MergeSort(new int[] { 7, 25, 45, 78, 11, 33, 19 }).SequenceEqual(new int[] { 7, 11, 19, 25, 33, 45, 78 }));
```

```csharp
Debug.Assert(MergeSort(new List<int> { 3, 1, 4, 9, 8 }).SequenceEqual(new List<int> { 1, 3, 4, 8, 9 }));
```
