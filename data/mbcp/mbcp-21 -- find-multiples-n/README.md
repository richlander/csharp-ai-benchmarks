# mbcp-21 -- Find m multiples of n using a function

## Text

Write a function to find m number of multiples of n.

## Code

```csharp
public List<int> MultiplesOfNum(int m, int n) 
{ 
    List<int> multiplesOfNum = new List<int>(); 
    for (int i = n; i <= (m + 1) * n; i += n) 
    { 
        multiplesOfNum.Add(i); 
    } 
    return multiplesOfNum; 
}
```

## Test List

```csharp
Debug.Assert(MultiplesOfNum(4, 3).SequenceEqual(new List<int> { 3, 6, 9, 12 }));
```

```csharp
Debug.Assert(MultiplesOfNum(2, 5).SequenceEqual(new List<int> { 5, 10 }));
```

```csharp
Debug.Assert(MultiplesOfNum(9, 2).SequenceEqual(new List<int> { 2, 4, 6, 8, 10, 12, 14, 16, 18 }));
```
