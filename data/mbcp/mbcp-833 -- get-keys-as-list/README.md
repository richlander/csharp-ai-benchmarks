# mbcp-833 -- Get dictionary keys and return as a list

## Text

Write a function to get dictionary keys as a list.

## Code

```csharp
public List<TKey> GetKey<TKey, TValue>(Dictionary<TKey, TValue> dict) 
{ 
    List<TKey> list = new List<TKey>(); 
    foreach (TKey key in dict.Keys) 
    { 
        list.Add(key); 
    } 
    return list; 
}
```

## Test List

```csharp
Debug.Assert(GetKey(new Dictionary<int, string> { { 1, "python" }, { 2, "java" } }).SequenceEqual(new List<int> { 1, 2 }));
```

```csharp
Debug.Assert(GetKey(new Dictionary<int, string> {{10, "red"}, {20, "blue"}, {30, "black"}}).SequenceEqual(new List<int> {10, 20, 30}));
```

```csharp
Debug.Assert(GetKey(new Dictionary<int, string> {{27, "language"}, {39, "java"}, {44, "little"}}).SequenceEqual(new List<int> {27, 39, 44}));
```
