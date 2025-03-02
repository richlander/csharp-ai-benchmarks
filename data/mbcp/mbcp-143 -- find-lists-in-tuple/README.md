# mbcp-143 -- Count lists in a given tuple using a function

## Text

Write a function to find number of lists present in the given tuple.

## Code

```csharp
public int FindLists(object Input) 
{
    if (Input is List<object>) 
    {
        return 1;
    }
    else 
    {
        return ((ICollection)Input).Count;
    }
}
```

## Test List

```csharp
Debug.Assert(FindLists(new List<int>[] { new List<int> { 1, 2, 3, 4 }, new List<int> { 5, 6, 7, 8 } }) == 2);
```

```csharp
Debug.Assert(FindLists(new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 3, 4 }, new List<int> { 5, 6 } }) == 3);
```

```csharp
Debug.Assert(FindLists(new List<int> { 9, 8, 7, 6, 5, 4, 3, 2, 1 }) == 1);
```
