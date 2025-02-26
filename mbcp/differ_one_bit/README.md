# 6 -- Check if two numbers differ at one bit only

differ_one_bit

## Prompt

Write a C# function to check whether the two numbers differ at one bit position only or not.

## Solution

```csharp
using System;
using System.Diagnostics;

bool IsPowerOfTwo(int x)
{
    return x != 0 && ((x & (x - 1)) == 0);
}

bool DifferAtOneBitPos(int a, int b)
{
    return IsPowerOfTwo(a ^ b);
}
```

## Tests

```csharp
Debug.Assert(DifferAtOneBitPos(13, 9) == true);
```

```csharp
Debug.Assert(DifferAtOneBitPos(15, 8) == false);
```

```csharp
Debug.Assert(DifferAtOneBitPos(2, 4) == false);
```
