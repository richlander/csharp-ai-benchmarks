# mbcp745 -- Find numbers divisible by their own digits

## Text

Write a function to find numbers within a given range where every number is divisible by every digit it contains.

## Code

```csharp
public List<int> DivisibleByDigits(int startnum, int endnum)
{
    return Enumerable.Range(startnum, endnum - startnum + 1)
                     .Where(n => !n.ToString().Any(x => int.Parse(x.ToString()) == 0 || n % int.Parse(x.ToString()) != 0))
                     .ToList();
}
```

## Test List

```csharp
Debug.Assert(DivisibleByDigits(1, 22).SequenceEqual(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22 }));
```

```csharp
Debug.Assert(DivisibleByDigits(1, 15).SequenceEqual(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15 }));
```

```csharp
Debug.Assert(DivisibleByDigits(20, 25).SequenceEqual(new List<int> { 22, 24 }));
```
