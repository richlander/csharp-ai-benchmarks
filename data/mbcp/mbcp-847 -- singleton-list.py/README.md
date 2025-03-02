# mbcp-847 -- Copy a list from a singleton tuple using Python

## Text

Write a C# function to copy a list from a singleton tuple.

## Code

```csharp
public List<T> Lcopy<T>(List<T> xs)
{
    return new List<T>(xs);
}
```

## Test List

```csharp
Debug.Assert(Lcopy(new List<int> { 1, 2, 3 }).SequenceEqual(new List<int> { 1, 2, 3 }));
```

```csharp
Debug.Assert(Lcopy(new List<int> { 4, 8, 2, 10, 15, 18 }).SequenceEqual(new List<int> { 4, 8, 2, 10, 15, 18 }));
```

```csharp
Debug.Assert(Lcopy(new List<int> { 4, 5, 6 }).SequenceEqual(new List<int> { 4, 5, 6 }));
```
