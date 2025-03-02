# mbcp-915 -- Rearrange positives and negatives in an array

## Text

Write a function to rearrange positive and negative numbers in a given array using lambda function.

## Code

```csharp
public List<int> RearrangeNumbs(List<int> arrayNums) 
{
    var result = arrayNums.OrderBy(i => i == 0 ? 0 : -1.0 / i).ToList();
    return result;
}
```

## Test List

```csharp
Debug.Assert(RearrangeNumbs(new List<int> { -1, 2, -3, 5, 7, 8, 9, -10 }).SequenceEqual(new List<int> { 2, 5, 7, 8, 9, -10, -3, -1 }));
```

```csharp
Debug.Assert(RearrangeNumbs(new List<int> { 10, 15, 14, 13, -18, 12, -20 }).SequenceEqual(new List<int> { 10, 12, 13, 14, 15, -20, -18 }));
```

```csharp
Debug.Assert(RearrangeNumbs(new int[] {-20, 20, -10, 10, -30, 30}).SequenceEqual(new int[] {10, 20, 30, -30, -20, -10}));
```
