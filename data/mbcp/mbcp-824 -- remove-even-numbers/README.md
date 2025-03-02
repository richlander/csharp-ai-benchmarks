# mbcp-824 -- Remove even numbers from a list using Python

## Text

Write a C# function to remove even numbers from a given list.

## Code

```csharp
public List<int> RemoveEven(List<int> l) 
{
    for (int i = 0; i < l.Count; i++) 
    {
        if (l[i] % 2 == 0) 
        {
            l.RemoveAt(i);
            i--; // Adjust index after removal
        }
    }
    return l;
}
```

## Test List

```csharp
Debug.Assert(RemoveEven(new List<int> { 1, 3, 5, 2 }).SequenceEqual(new List<int> { 1, 3, 5 }));
```

```csharp
Debug.Assert(RemoveEven(new List<int> { 5, 6, 7 }).SequenceEqual(new List<int> { 5, 7 }));
```

```csharp
Debug.Assert(RemoveEven(new List<int> { 1, 2, 3, 4 }).SequenceEqual(new List<int> { 1, 3 }));
```
