# mbcp775 -- Check if odd indices have odd numbers

## Text

Write a C# function to check whether every odd index contains odd numbers of a given list.

## Code

```csharp
public bool OddPosition(List<int> nums)
{
    return nums.Select((num, i) => num % 2 == i % 2).All(x => x);
}
```

## Test List

```csharp
Debug.Assert(OddPosition(new List<int> { 2, 1, 4, 3, 6, 7, 6, 3 }) == true);
```

```csharp
Debug.Assert(OddPosition(new int[] { 4, 1, 2 }) == true);
```

```csharp
Debug.Assert(OddPosition(new int[] { 1, 2, 3 }) == false);
```
