# mbcp-873 -- Recursive function to calculate Fibonacci numbers

## Text

Write a function to solve the fibonacci sequence using recursion.

## Code

```csharp
public int Fibonacci(int n)
{
    if (n == 1 || n == 2)
        return 1;
    else
        return Fibonacci(n - 1) + Fibonacci(n - 2);
}
```

## Test List

```csharp
Debug.Assert(Fibonacci(7) == 13);
```

```csharp
Debug.Assert(Fibonacci(8) == 21);
```

```csharp
Debug.Assert(Fibonacci(9) == 34);
```
