# mbcp-10 -- Get the n smallest items from a dataset

## Text

Write a function to get the n smallest items from a dataset.

## Code

```csharp
public List<int> SmallNNum(List<int> list1, int n) {
    var smallest = list1.OrderBy(x => x).Take(n).ToList();
    return smallest;
}
```

## Test List

```csharp
Debug.Assert(SmallNNum(new int[] { 10, 20, 50, 70, 90, 20, 50, 40, 60, 80, 100 }, 2).SequenceEqual(new int[] { 10, 20 }));
```

```csharp
Debug.Assert(SmallNNum(new int[] { 10, 20, 50, 70, 90, 20, 50, 40, 60, 80, 100 }, 5).SequenceEqual(new int[] { 10, 20, 20, 40, 50 }));
```

```csharp
Debug.Assert(SmallNNum(new int[] { 10, 20, 50, 70, 90, 20, 50, 40, 60, 80, 100 }, 3).SequenceEqual(new int[] { 10, 20, 20 }));
```
