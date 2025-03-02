# mbcp-618 -- Divide two lists using map and lambda functions

## Text

Write a function to divide two lists using map and lambda function.

## Code

```csharp
public List<double> DivList(List<double> nums1, List<double> nums2) {
    var result = nums1.Zip(nums2, (x, y) => x / y);
    return result.ToList();
}
```

## Test List

```csharp
Debug.Assert(DivList(new List<int> { 4, 5, 6 }, new List<int> { 1, 2, 3 }).SequenceEqual(new List<double> { 4.0, 2.5, 2.0 }));
```

```csharp
Debug.Assert(DivList(new double[] { 3, 2 }, new double[] { 1, 4 }).SequenceEqual(new double[] { 3.0, 0.5 }));
```

```csharp
Debug.Assert(DivList(new int[] { 90, 120 }, new int[] { 50, 70 }).SequenceEqual(new double[] { 1.8, 1.7142857142857142 }));
```
