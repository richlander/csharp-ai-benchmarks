# mbcp-625 -- Interchange first and last list elements in Python

## Text

Write a C# function to interchange first and last elements in a given list.

## Code

```csharp
public List<T> SwapList<T>(List<T> newList) 
{ 
    int size = newList.Count; 
    T temp = newList[0]; 
    newList[0] = newList[size - 1]; 
    newList[size - 1] = temp;   
    return newList; 
}
```

## Test List

```csharp
Debug.Assert(SwapList(new List<int> { 1, 2, 3 }).SequenceEqual(new List<int> { 3, 2, 1 }));
```

```csharp
Debug.Assert(SwapList(new List<int> { 1, 2, 3, 4, 4 }).SequenceEqual(new List<int> { 4, 2, 3, 4, 1 }));
```

```csharp
Debug.Assert(SwapList(new List<int> { 4, 5, 6 }).SequenceEqual(new List<int> { 6, 5, 4 }));
```
