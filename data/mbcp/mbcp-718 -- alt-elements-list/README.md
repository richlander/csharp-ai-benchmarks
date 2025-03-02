# mbcp-718 -- Create a list of alternate elements from another list

## Text

Write a function to create a list taking alternate elements from another given list.

## Code

```csharp
public List<T> AlternateElements<T>(List<T> list1)
{
    List<T> result = new List<T>();
    for (int i = 0; i < list1.Count; i += 2)
    {
        result.Add(list1[i]);
    }
    return result;
}
```

## Test List

```csharp
Debug.Assert(AlternateElements(new string[] { "red", "black", "white", "green", "orange" }).SequenceEqual(new string[] { "red", "white", "orange" }));
```

```csharp
Debug.Assert(AlternateElements(new List<int> { 2, 0, 3, 4, 0, 2, 8, 3, 4, 2 }).SequenceEqual(new List<int> { 2, 3, 0, 8, 4 }));
```

```csharp
Debug.Assert(AlternateElements(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }).SequenceEqual(new int[] { 1, 3, 5, 7, 9 }));
```
