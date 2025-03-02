# mbcp249 -- Find intersection of two arrays with lambda function

## Text

Write a function to find the intersection of two arrays using lambda function.

## Code

```csharp
public List<int> IntersectionArray(int[] arrayNums1, int[] arrayNums2) 
{
    return arrayNums2.Where(x => arrayNums1.Contains(x)).ToList();
}
```

## Test List

```csharp
Debug.Assert(IntersectionArray(new int[] { 1, 2, 3, 5, 7, 8, 9, 10 }, new int[] { 1, 2, 4, 8, 9 }).SequenceEqual(new int[] { 1, 2, 8, 9 }));
```

```csharp
Debug.Assert(IntersectionArray(new int[] { 1, 2, 3, 5, 7, 8, 9, 10 }, new int[] { 3, 5, 7, 9 }).SequenceEqual(new int[] { 3, 5, 7, 9 }));
```

```csharp
Debug.Assert(IntersectionArray(new int[] { 1, 2, 3, 5, 7, 8, 9, 10 }, new int[] { 10, 20, 30, 40 }).SequenceEqual(new int[] { 10 }));
```
