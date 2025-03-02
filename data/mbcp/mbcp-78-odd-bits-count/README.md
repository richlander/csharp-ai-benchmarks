# mbcp78 -- Count integers with an odd number of set bits

## Text

Write a C# function to find number of integers with odd number of set bits.

## Code

```csharp
public static double Count_With_Odd_SetBits(int n) 
{ 
    if (n % 2 != 0) 
    { 
        return (n + 1) / 2.0; 
    } 
    int count = Convert.ToString(n, 2).Count(c => c == '1'); 
    double ans = n / 2.0; 
    if (count % 2 != 0) 
    { 
        ans += 1; 
    } 
    return ans; 
}
```

## Test List

```csharp
Debug.Assert(Count_With_Odd_SetBits(5) == 3);
```

```csharp
Debug.Assert(Count_With_Odd_SetBits(10) == 5);
```

```csharp
Debug.Assert(Count_With_Odd_SetBits(15) == 8);
```
