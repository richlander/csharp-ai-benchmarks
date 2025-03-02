# mbcp-876 -- Find the lcm of two positive integers in Python

## Text

Write a C# function to find lcm of two positive integers.

## Code

```csharp
public static int Lcm(int x, int y)
{
    int z = (x > y) ? x : y;
    while (true)
    {
        if ((z % x == 0) && (z % y == 0))
        {
            return z;
        }
        z++;
    }
}
```

## Test List

```csharp
Debug.Assert(Lcm(4, 6) == 12);
```

```csharp
Debug.Assert(Lcm(15, 17) == 255);
```

```csharp
Debug.Assert(Lcm(2, 6) == 6);
```
