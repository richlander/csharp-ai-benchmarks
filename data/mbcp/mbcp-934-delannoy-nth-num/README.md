# mbcp934 -- Find the nth Delannoy number using a function

## Text

Write a function to find the nth delannoy number.

## Code

```csharp
public int DealnnoyNum(int n, int m) 
{ 
    if (m == 0 || n == 0) 
    { 
        return 1; 
    } 
    return DealnnoyNum(m - 1, n) + DealnnoyNum(m - 1, n - 1) + DealnnoyNum(m, n - 1); 
}
```

## Test List

```csharp
Debug.Assert(DealnnoyNum(3, 4) == 129);
```

```csharp
Debug.Assert(DealnnoyNum(3, 3) == 63);
```

```csharp
Debug.Assert(DealnnoyNum(4, 5) == 681);
```
