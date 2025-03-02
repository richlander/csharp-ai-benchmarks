# mbcp-644 -- Reverse an array up to a specified position in Python

## Text

Write a C# function to reverse an array upto a given position.

## Code

```csharp
public static List<T> ReverseArrayUptoK<T>(List<T> input, int k) 
{
    return input.Take(k).Reverse().Concat(input.Skip(k)).ToList();
}
```

## Test List

```csharp
Debug.Assert(ReverseArrayUptoK(new int[] { 1, 2, 3, 4, 5, 6 }, 4).SequenceEqual(new int[] { 4, 3, 2, 1, 5, 6 }));
```

```csharp
Debug.Assert(ReverseArrayUptoK(new int[] { 4, 5, 6, 7 }, 2).SequenceEqual(new int[] { 5, 4, 6, 7 }));
```

```csharp
Debug.Assert(ReverseArrayUptoK(new int[] { 9, 8, 7, 6, 5 }, 3).SequenceEqual(new int[] { 7, 8, 9, 6, 5 }));
```
