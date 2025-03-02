# mbcp-629 -- Find even numbers in a mixed list using Python

## Text

Write a C# function to find even numbers from a mixed list.

## Code

```csharp
public List<int> Split(List<int> list) 
{ 
    List<int> ev_li = new List<int>(); 
    foreach (int i in list) 
    { 
        if (i % 2 == 0) 
        { 
            ev_li.Add(i); 
        } 
    } 
    return ev_li; 
}
```

## Test List

```csharp
Debug.Assert(Split(new int[] { 1, 2, 3, 4, 5 }).SequenceEqual(new int[] { 2, 4 }));
```

```csharp
Debug.Assert(Split(new int[] { 4, 5, 6, 7, 8, 0, 1 }).SequenceEqual(new int[] { 4, 6, 8, 0 }));
```

```csharp
Debug.Assert(Split(new int[] { 8, 12, 15, 19 }).SequenceEqual(new int[] { 8, 12 }));
```
