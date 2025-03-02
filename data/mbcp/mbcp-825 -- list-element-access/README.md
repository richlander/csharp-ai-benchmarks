# mbcp-825 -- Access list elements by specified indices in Python

## Text

Write a C# function to access multiple elements of specified index from a given list.

## Code

```csharp
public List<int> AccessElements(List<int> nums, List<int> listIndex) {
    List<int> result = new List<int>();
    foreach (int i in listIndex) {
        result.Add(nums[i]);
    }
    return result;
}
```

## Test List

```csharp
Debug.Assert(AccessElements(new int[] { 2, 3, 8, 4, 7, 9 }, new int[] { 0, 3, 5 }).SequenceEqual(new int[] { 2, 4, 9 }));
```

```csharp
Debug.Assert(AccessElements(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2 }).SequenceEqual(new int[] { 2, 3 }));
```

```csharp
Debug.Assert(AccessElements(new int[] { 1, 0, 2, 3 }, new int[] { 0, 1 }).SequenceEqual(new int[] { 1, 0 }));
```
