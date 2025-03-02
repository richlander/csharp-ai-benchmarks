# mbcp-577 -- Find the last digit of a factorial in Python

## Text

Write a C# function to find the last digit in factorial of a given number.

## Code

```csharp
public int LastDigitFactorial(int n) 
{
    if (n == 0) return 1;
    else if (n <= 2) return n;
    else if (n == 3) return 6;
    else if (n == 4) return 4;
    else return 0;
}
```

## Test List

```csharp
Debug.Assert(LastDigitFactorial(4) == 4);
```

```csharp
Debug.Assert(LastDigitFactorial(21) == 0);
```

```csharp
Debug.Assert(LastDigitFactorial(30) == 0);
```
