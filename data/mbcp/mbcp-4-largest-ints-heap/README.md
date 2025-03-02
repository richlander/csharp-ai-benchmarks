# mbcp4 -- Find largest integers using a heap queue algorithm

## Text

Write a function to find the largest integers from a given list of numbers using heap queue algorithm.

## Code

```csharp
public List<int> HeapQueueLargest(List<int> nums, int n) 
{
    return nums.OrderByDescending(x => x).Take(n).ToList();
}
```

## Test List

```csharp
Debug.Assert(HeapQueueLargest(new List<int> { 25, 35, 22, 85, 14, 65, 75, 22, 58 }, 3).SequenceEqual(new List<int> { 85, 75, 65 }));
```

```csharp
Debug.Assert(HeapQueueLargest(new List<int> { 25, 35, 22, 85, 14, 65, 75, 22, 58 }, 2).SequenceEqual(new List<int> { 85, 75 }));
```

```csharp
Debug.Assert(HeapQueueLargest(new int[] { 25, 35, 22, 85, 14, 65, 75, 22, 58 }, 5).SequenceEqual(new int[] { 85, 75, 65, 58, 35 }));
```
