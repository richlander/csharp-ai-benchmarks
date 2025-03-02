# mbcp-62 -- Find the smallest number in a list using Python

## Text

Write a C# function to find smallest number in a list.

## Code

```csharp
public static int SmallestNum(IEnumerable<int> xs)
{
    return xs.Min();
}
```

## Test List

```csharp
Debug.Assert(SmallestNum(new int[] { 10, 20, 1, 45, 99 }) == 1);
```

```csharp
Debug.Assert(SmallestNum(new int[] { 1, 2, 3 }) == 1);
```

```csharp
Debug.Assert(SmallestNum(new int[] { 45, 46, 50, 60 }) == 45);
```
