# mbcp-398 -- Sum the digits of each number in a list

## Text

Write a function to compute the sum of digits of each number of a given list.

## Code

```csharp
public int SumOfDigits(IEnumerable<int> nums)
{
    return nums.Sum(n => n.ToString().Sum(el => char.IsDigit(el) ? int.Parse(el.ToString()) : 0));
}
```

## Test List

```csharp
Debug.Assert(SumOfDigits(new int[] { 10, 2, 56 }) == 14);
```

```csharp
Debug.Assert(SumOfDigits(new object[][] { new object[] { 10, 20, 4, 5, 'b', 70, 'a' } }) == 19);
```

```csharp
Debug.Assert(SumOfDigits(new int[] { 10, 20, -4, 5, -70 }) == 19);
```
