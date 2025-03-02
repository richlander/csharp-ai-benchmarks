# mbcp148 -- Maximize digit sum by splitting a number

## Text

Write a function to divide a number into two parts such that the sum of digits is maximum.

## Code

```csharp
int SumDigitsSingle(int x) 
{ 
    int ans = 0; 
    while (x != 0) 
    { 
        ans += x % 10; 
        x /= 10; 
    } 
    return ans; 
}

int Closest(int x) 
{ 
    int ans = 0; 
    while (ans * 10 + 9 <= x) 
    { 
        ans = ans * 10 + 9; 
    } 
    return ans; 
}

int SumDigitsTwoParts(int N) 
{ 
    int A = Closest(N); 
    return SumDigitsSingle(A) + SumDigitsSingle(N - A); 
}
```

## Test List

```csharp
Debug.Assert(SumDigitsTwoParts(35) == 17);
```

```csharp
Debug.Assert(SumDigitsTwoParts(7) == 7);
```

```csharp
Debug.Assert(SumDigitsTwoParts(100) == 19);
```
