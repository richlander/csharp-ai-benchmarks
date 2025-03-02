# mbcp-340 -- Find the sum of the three smallest positive numbers

## Text

Write a C# function to find the sum of the three lowest positive numbers from a given list of numbers.

## Code

```csharp
public int SumThreeSmallestNums(List<int> lst)
{
    return lst.Where(x => x > 0).OrderBy(x => x).Take(3).Sum();
}
```

## Test List

```csharp
Debug.Assert(SumThreeSmallestNums(new int[] { 10, 20, 30, 40, 50, 60, 7 }) == 37);
```

```csharp
Debug.Assert(SumThreeSmallestNums(new int[] { 1, 2, 3, 4, 5 }) == 6);
```

```csharp
Debug.Assert(SumThreeSmallestNums(new int[] { 0, 1, 2, 3, 4, 5 }) == 6);
```
