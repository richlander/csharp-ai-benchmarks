# mbcp801 -- Count matching integers from three given values

## Text

Write a C# function to count the number of equal numbers from three given integers.

## Code

```csharp
public int TestThreeEqual(int x, int y, int z)
{
    var result = new HashSet<int> { x, y, z };
    if (result.Count == 3)
    {
        return 0;
    }
    else
    {
        return 4 - result.Count;
    }
}
```

## Test List

```csharp
Debug.Assert(TestThreeEqual(1, 1, 1) == 3);
```

```csharp
Debug.Assert(TestThreeEqual(-1, -2, -3) == 0);
```

```csharp
Debug.Assert(TestThreeEqual(1, 2, 2) == 2);

public int TestThreeEqual(int a, int b, int c)
{
    if (a == b && b == c)
        return a;
    if (a == b)
        return a;
    if (a == c)
        return a;
    if (b == c)
        return b;
    return -1; // or throw an exception based on your use case
}
```
