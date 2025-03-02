# mbcp-605 -- Check if an integer is a prime number

## Text

Write a function to check if the given integer is a prime number.

## Code

```csharp
public bool PrimeNum(int num)
{
    if (num >= 1)
    {
        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    else
    {
        return false;
    }
}
```

## Test List

```csharp
Debug.Assert(PrimeNum(13) == true);
```

```csharp
Debug.Assert(PrimeNum(7) == true);
```

```csharp
Debug.Assert(PrimeNum(-1010) == false);
```
