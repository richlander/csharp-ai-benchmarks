# mbcp3 -- Identify non-prime numbers using Python function

## Text

Write a C# function to identify non-prime numbers.

## Code

```csharp
public bool IsNotPrime(int n) 
{
    bool result = false;
    for (int i = 2; i <= (int)Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            result = true;
        }
    }
    return result;
}
```

## Test List

```csharp
Debug.Assert(IsNotPrime(2) == false);
```

```csharp
Debug.Assert(IsNotPrime(10) == true);
```

```csharp
Debug.Assert(IsNotPrime(35) == true);
```
