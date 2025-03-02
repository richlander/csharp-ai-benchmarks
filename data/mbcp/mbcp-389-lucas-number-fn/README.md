# mbcp389 -- Calculate the nth Lucas number using a function

## Text

Write a function to find the n'th lucas number.

## Code

```csharp
public int FindLucas(int n) 
{
    if (n == 0) 
    {
        return 2;
    }
    if (n == 1) 
    {
        return 1;
    }
    return FindLucas(n - 1) + FindLucas(n - 2);
}
```

## Test List

```csharp
Debug.Assert(FindLucas(9) == 76);
```

```csharp
Debug.Assert(FindLucas(4) == 7);
```

```csharp
Debug.Assert(FindLucas(3) == 4);
```
