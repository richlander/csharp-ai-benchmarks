# mbcp554 -- Find odd numbers in a mixed list using Python

## Text

Write a C# function to find odd numbers from a mixed list.

## Code

```csharp
public List<int> Split(List<int> list) 
{ 
    List<int> odLi = new List<int>(); 
    foreach (int i in list) 
    { 
        if (i % 2 != 0) 
        { 
            odLi.Add(i); 
        } 
    } 
    return odLi; 
}
```

## Test List

```csharp
Debug.Assert(Split(new int[] { 1, 2, 3, 4, 5, 6 }).SequenceEqual(new int[] { 1, 3, 5 }));
```

```csharp
Debug.Assert(Split(new int[] { 10, 11, 12, 13 }).SequenceEqual(new int[] { 11, 13 }));
```

```csharp
Debug.Assert(Split(new int[] { 7, 8, 9, 1 }).SequenceEqual(new int[] { 7, 9, 1 }));
```
