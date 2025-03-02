# mbcp566 -- Sum digits of a non-negative integer efficiently

## Text

Write a function to get the sum of a non-negative integer.

## Code

```csharp
public int SumDigits(int n) {
    if (n == 0) {
        return 0;
    } else {
        return n % 10 + SumDigits(n / 10);
    }
}
```

## Test List

```csharp
Debug.Assert(SumDigits(345) == 12);
```

```csharp
Debug.Assert(SumDigits(12) == 3);
```

```csharp
Debug.Assert(SumDigits(97) == 16);
```
