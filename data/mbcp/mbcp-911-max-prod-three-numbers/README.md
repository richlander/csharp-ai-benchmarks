# mbcp911 -- Compute max product of three integers using heaps

## Text

Write a function to compute maximum product of three numbers of a given array of integers using heap queue algorithm.

## Code

```csharp
public int MaximumProduct(int[] nums) {
    var a = nums.OrderByDescending(x => x).Take(3).ToArray();
    var b = nums.OrderBy(x => x).Take(2).ToArray();
    return Math.Max(a[0] * a[1] * a[2], a[0] * b[0] * b[1]);
}
```

## Test List

```csharp
Debug.Assert(MaximumProduct(new int[] { 12, 74, 9, 50, 61, 41 }) == 225700);
```

```csharp
Debug.Assert(MaximumProduct(new int[] { 25, 35, 22, 85, 14, 65, 75, 25, 58 }) == 414375);
```

```csharp
Debug.Assert(MaximumProduct(new int[] { 18, 14, 10, 9, 8, 7, 9, 3, 2, 4, 1 }) == 2520);
```
