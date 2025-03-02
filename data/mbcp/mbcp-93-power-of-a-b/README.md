# mbcp93 -- Calculate a raised to the power of b

## Text

Write a function to calculate the value of 'a' to the power 'b'.

## Code

```csharp
public static int Power(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    else if (a == 0)
    {
        return 0;
    }
    else if (b == 1)
    {
        return a;
    }
    else
    {
        return a * Power(a, b - 1);
    }
}
```

## Test List

```csharp
Debug.Assert(Power(3, 4) == 81);
```

```csharp
Debug.Assert(Power(2, 3) == 8);
```

```csharp
Debug.Assert(Power(5, 5) == 3125);
```
