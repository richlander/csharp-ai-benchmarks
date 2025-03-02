# mbcp115 -- Check if all dictionaries in a list are empty

## Text

Write a function to check whether all dictionaries in a list are empty or not.

## Code

```csharp
bool EmptyDit(List<object> list1) {
    bool emptyDit = list1.All(d => !d);
    return emptyDit;
}
```

## Test List

```csharp
Debug.Assert(EmptyDit(new List<Dictionary<string, object>> { new Dictionary<string, object>(), new Dictionary<string, object>(), new Dictionary<string, object>() }) == true);
```

```csharp
Debug.Assert(EmptyDit(new List<HashSet<int>> { new HashSet<int> { 1, 2 }, new HashSet<int>(), new HashSet<int>() }) == false);
```

```csharp
Debug.Assert(EmptyDit(new Dictionary<string, object>()) == true);
```
