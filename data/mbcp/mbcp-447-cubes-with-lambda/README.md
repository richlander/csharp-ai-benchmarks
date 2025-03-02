# mbcp447 -- Find cubes of list elements with a lambda function

## Text

Write a function to find cubes of individual elements in a list using lambda function.

## Code

```csharp
public List<int> CubeNums(List<int> nums)  
{  
    List<int> cubeNums = nums.Select(x => x * x * x).ToList();  
    return cubeNums;  
}
```

## Test List

```csharp
Debug.Assert(CubeNums(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }).SequenceEqual(new int[] { 1, 8, 27, 64, 125, 216, 343, 512, 729, 1000 }));
```

```csharp
Debug.Assert(CubeNums(new int[] { 10, 20, 30 }).SequenceEqual(new int[] { 1000, 8000, 27000 }));
```

```csharp
Debug.Assert(CubeNums(new int[] { 12, 15 }).SequenceEqual(new int[] { 1728, 3375 }));
```
