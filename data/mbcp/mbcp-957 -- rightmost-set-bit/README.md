# mbcp-957 -- Find the position of the rightmost set bit

## Text

Write a C# function to get the position of rightmost set bit.

## Code

```csharp
public static int GetFirstSetBitPos(int n)
{
    return (int)(Math.Log2(n & -n) + 1);
}
```

## Test List

```csharp
Debug.Assert(GetFirstSetBitPos(12) == 3);
```

```csharp
Debug.Assert(GetFirstSetBitPos(18) == 2);
```

```csharp
Debug.Assert(GetFirstSetBitPos(16) == 5);
```
