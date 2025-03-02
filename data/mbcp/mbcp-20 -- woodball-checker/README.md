# mbcp-20 -- Check if a number is woodball or not

## Text

Write a function to check if the given number is woodball or not.

## Code

```csharp
public bool IsWoodall(int x) 
{
    if (x % 2 == 0) 
    {
        return false;
    }
    if (x == 1) 
    {
        return true;
    }
    x = x + 1;
    int p = 0;
    while (x % 2 == 0) 
    {
        x = x / 2;
        p = p + 1;
        if (p == x) 
        {
            return true;
        }
    }
    return false;
}
```

## Test List

```csharp
Debug.Assert(IsWoodall(383) == true);
```

```csharp
Debug.Assert(IsWoodall(254) == false);
```

```csharp
Debug.Assert(IsWoodall(200) == false);
```
