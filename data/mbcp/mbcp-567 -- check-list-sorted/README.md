# mbcp-567 -- Check if a list is sorted in ascending order

## Text

Write a function to check whether a specified list is sorted or not.

## Code

```csharp
public static bool IsSortList(List<int> list1) {
    bool result = list1.Zip(list1.Skip(1), (a, b) => a <= b).All(x => x);
    return result;
}
```

## Test List

```csharp
Debug.Assert(IsSortList(new List<int> { 1, 2, 4, 6, 8, 10, 12, 14, 16, 17 }) == true);
```

```csharp
Debug.Assert(IsSortList(new List<int> { 1, 2, 4, 6, 8, 10, 12, 14, 20, 17 }) == false);
```

```csharp
Debug.Assert(IsSortList(new List<int> { 1, 2, 4, 6, 8, 10, 15, 14, 20 }) == false);
```
