# mbcp645 -- Find product of kth index in given tuples

## Text

Write a function to find the product of it’s kth index in the given tuples.

## Code

```csharp
public int GetProduct(List<int> val) 
{ 
    int res = 1; 
    foreach (int ele in val) 
    { 
        res *= ele; 
    } 
    return res; 
} 

public int FindKProduct(List<List<int>> testList, int K) 
{ 
    int res = GetProduct(testList.Select(sub => sub[K]).ToList()); 
    return res; 
}
```

## Test List

```csharp
Debug.Assert(FindKProduct(new (int, int, int)[] { (5, 6, 7), (1, 3, 5), (8, 9, 19) }, 2) == 665);
```

```csharp
Debug.Assert(FindKProduct(new Tuple<int, int, int>[] { Tuple.Create(6, 7, 8), Tuple.Create(2, 4, 6), Tuple.Create(9, 10, 20) }, 1) == 280);
```

```csharp
Debug.Assert(FindKProduct(new (int, int, int)[] { (7, 8, 9), (3, 5, 7), (10, 11, 21) }, 0) == 210);
```
