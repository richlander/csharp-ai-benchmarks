# mbcp-514 -- Sum elements of tuples in a given list

## Text

Write a function to find the summation of tuple elements in the given tuple list.

## Code

```csharp
public static int SumElements(IEnumerable<int> testTup)  
{  
    int res = testTup.Sum();  
    return res;  
}
```

## Test List

```csharp
Debug.Assert(SumElements(new int[] { 7, 8, 9, 1, 10, 7 }) == 42);
```

```csharp
Debug.Assert(SumElements(new int[] { 1, 2, 3, 4, 5, 6 }) == 21);
```

```csharp
Debug.Assert(SumElements(new int[] { 11, 12, 13, 45, 14 }) == 95);
```
