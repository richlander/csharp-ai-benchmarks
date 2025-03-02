# mbcp591 -- Interchange first and last elements in a list

## Text

Write a C# function to interchange the first and last elements in a list.

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
Debug.Assert(SwapList(new List<int> { 12, 35, 9, 56, 24 }).SequenceEqual(new List<int> { 24, 35, 9, 56, 12 }));
```

```csharp
Debug.Assert(SwapList(new List<int> { 1, 2, 3 }).SequenceEqual(new List<int> { 3, 2, 1 }));
```

```csharp
Debug.Assert(SwapList(new List<int> { 4, 5, 6 }).SequenceEqual(new List<int> { 6, 5, 4 }));

public List<int> SwapList(List<int> inputList) {
    inputList.Reverse();
    return inputList;
}
```
