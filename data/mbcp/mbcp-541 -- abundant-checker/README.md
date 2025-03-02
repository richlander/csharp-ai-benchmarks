# mbcp-541 -- Check if a number is abundant or not

## Text

Write a function to find if the given number is abundant or not.

## Code

```csharp
public static int GetSum(int n) 
{ 
    int sum = 0; 
    int i = 1; 
    while (i <= (int)Math.Sqrt(n)) 
    { 
        if (n % i == 0) 
        { 
            if (n / i == i) 
            { 
                sum += i; 
            } 
            else 
            { 
                sum += i; 
                sum += (n / i); 
            } 
        } 
        i++; 
    } 
    sum -= n; 
    return sum; 
}

public static bool CheckAbundant(int n) 
{ 
    return GetSum(n) > n; 
}
```

## Test List

```csharp
Debug.Assert(CheckAbundant(12) == true);
```

```csharp
Debug.Assert(CheckAbundant(15) == false);
```

```csharp
Debug.Assert(CheckAbundant(18) == true);
```
