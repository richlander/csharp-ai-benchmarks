# mbcp250 -- Count occurrences of an element in a tuple

## Text

Write a C# function to count the occcurences of an element in a tuple.

## Code

```csharp
public int CountX(Tuple<int>[] tup, int x) 
{ 
    int count = 0; 
    foreach (var ele in tup) 
    { 
        if (ele.Item1 == x) 
        { 
            count++; 
        } 
    } 
    return count; 
}
```

## Test List

```csharp
Debug.Assert(CountX(new int[] { 10, 8, 5, 2, 10, 15, 10, 8, 5, 8, 8, 2 }, 4) == 0);
```

```csharp
Debug.Assert(CountX(new int[] { 10, 8, 5, 2, 10, 15, 10, 8, 5, 8, 8, 2 }, 10) == 3);
```

```csharp
Debug.Assert(CountX(new int[] { 10, 8, 5, 2, 10, 15, 10, 8, 5, 8, 8, 2 }, 8) == 4);
```
