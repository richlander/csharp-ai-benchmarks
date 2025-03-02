# mbcp-177 -- Find two numbers with LCM in specified range

## Text

Write a C# function to find two distinct numbers such that their lcm lies within the given range.

## Code

```csharp
public (int, int) Answer(int L, int R) 
{
    if (2 * L <= R)
    {
        return (L, 2 * L);
    }
    else
    {
        return (-1, -1);
    }
}
```

## Test List

```csharp
Debug.Assert(Answer(3, 8).Equals((3, 6)));
```

```csharp
Debug.Assert(Answer(2, 6).Equals(ValueTuple.Create(2, 4)));
```

```csharp
Debug.Assert(Answer(1, 3).Equals((1, 2)));
```
