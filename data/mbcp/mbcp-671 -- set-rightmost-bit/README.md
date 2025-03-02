# mbcp-671 -- Set the rightmost unset bit in an integer

## Text

Write a C# function to set the right most unset bit.

## Code

```csharp
using System;

public class BitManipulation
{
    public static int GetPosOfRightMostSetBit(int n)
    {
        return (int)Math.Floor(Math.Log2(n & -n) + 1);
    }

    public static int SetRightMostUnsetBit(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        if ((n & (n + 1)) == 0)
        {
            return n;
        }
        int pos = GetPosOfRightMostSetBit(~n);
        return ((1 << (pos - 1)) | n);
    }
}
```

## Test List

```csharp
Debug.Assert(SetRightMostUnsetBit(21) == 23);
```

```csharp
Debug.Assert(SetRightMostUnsetBit(11) == 15);
```

```csharp
Debug.Assert(SetRightMostUnsetBit(15) == 15);
```
