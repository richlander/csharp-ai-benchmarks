# mbcp-807 -- Find the first odd number in a list of integers

## Text

Write a C# function to find the first odd number in a given list of numbers.

## Code

```csharp
public int FirstOdd(List<int> nums) 
{
    return nums.FirstOrDefault(el => el % 2 != 0) == 0 ? -1 : nums.First(el => el % 2 != 0);
}
```

## Test List

```csharp
Debug.Assert(FirstOdd(new int[] { 1, 3, 5 }) == 1);
```

```csharp
Debug.Assert(FirstOdd(new int[] { 2, 4, 1, 3 }) == 1);
```

```csharp
Debug.Assert(FirstOdd(new int[] { 8, 9, 1 }) == 9);
```
