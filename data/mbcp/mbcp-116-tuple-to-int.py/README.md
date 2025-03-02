# mbcp116 -- Convert a tuple of integers to a single integer

## Text

Write a function to convert a given tuple of positive integers into an integer.

## Code

```csharp
public int TupleToInt(int[] nums)
{
    string result = string.Join("", nums.Select(n => n.ToString()));
    return int.Parse(result);
}
```

## Test List

```csharp
Debug.Assert(TupleToInt((1, 2, 3)) == 123);
```

```csharp
Debug.Assert(TupleToInt((4, 5, 6)) == 456);
```

```csharp
Debug.Assert(TupleToInt((5, 6, 7)) == 567);
```
