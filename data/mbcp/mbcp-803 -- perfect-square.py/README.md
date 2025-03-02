# mbcp-803 -- Check if a number is a perfect square in Python

## Text

Write a C# function to check whether the given number is a perfect square or not.

## Code

```csharp
public bool IsPerfectSquare(int n) 
{
    int i = 1;
    while (i * i <= n)
    {
        if ((n % i == 0) && (n / i == i))
        {
            return true;     
        }
        i++;
    }
    return false;
}
```

## Test List

```csharp
Debug.Assert(IsPerfectSquare(10) == false);
```

```csharp
Debug.Assert(IsPerfectSquare(36) == true);
```

```csharp
Debug.Assert(IsPerfectSquare(14) == false);
```
