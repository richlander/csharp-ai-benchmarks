# mbcp-511 -- Find minimum sum of factors for a given number

## Text

Write a C# function to find minimum sum of factors of a given number.

## Code

```csharp
public int FindMinSum(int num) 
{ 
    int sum = 0; 
    int i = 2; 
    while (i * i <= num) 
    { 
        while (num % i == 0) 
        { 
            sum += i; 
            num /= i; 
        } 
        i++; 
    } 
    sum += num; 
    return sum; 
}
```

## Test List

```csharp
Debug.Assert(FindMinSum(12) == 7);
```

```csharp
Debug.Assert(FindMinSum(105) == 15);
```

```csharp
Debug.Assert(FindMinSum(2) == 2);
```
