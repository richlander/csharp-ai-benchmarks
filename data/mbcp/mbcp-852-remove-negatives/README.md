# mbcp852 -- Remove negative numbers from a list in Python

## Text

Write a C# function to remove negative numbers from a list.

## Code

```csharp
public List<int> RemoveNegs(List<int> numList) 
{ 
    for (int i = numList.Count - 1; i >= 0; i--) 
    { 
        if (numList[i] < 0) 
        { 
            numList.RemoveAt(i); 
        } 
    } 
    return numList; 
}
```

## Test List

```csharp
Debug.Assert(RemoveNegs(new List<int> { 1, -2, 3, -4 }).SequenceEqual(new List<int> { 1, 3 }));
```

```csharp
Debug.Assert(RemoveNegs(new List<int> { 1, 2, 3, -4 }).SequenceEqual(new List<int> { 1, 2, 3 }));
```

```csharp
Debug.Assert(RemoveNegs(new List<int> { 4, 5, -6, 7, -8 }).SequenceEqual(new List<int> { 4, 5, 7 }));
```
