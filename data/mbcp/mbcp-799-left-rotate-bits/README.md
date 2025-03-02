# mbcp799 -- Rotate bits of a number to the left in Python

## Text

Write a C# function to left rotate the bits of a given number.

## Code

```csharp
const int INT_BITS = 32;

public static int LeftRotate(int n, int d)   
{
    return (n << d) | (n >> (INT_BITS - d));
}
```

## Test List

```csharp
Debug.Assert(LeftRotate(16, 2) == 64);
```

```csharp
Debug.Assert(LeftRotate(10, 2) == 40);
```

```csharp
Debug.Assert(LeftRotate(99, 3) == 792);
```
