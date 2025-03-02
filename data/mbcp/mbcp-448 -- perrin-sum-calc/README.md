# mbcp-448 -- Calculate the sum of Perrin numbers in a function

## Text

Write a function to calculate the sum of perrin numbers.

## Code

```csharp
public int CalSum(int n) 
{ 
    int a = 3; 
    int b = 0; 
    int c = 2; 
    if (n == 0) 
        return 3; 
    if (n == 1) 
        return 3; 
    if (n == 2) 
        return 5; 
    int sum = 5; 
    while (n > 2) 
    { 
        int d = a + b; 
        sum += d; 
        a = b; 
        b = c; 
        c = d; 
        n--; 
    } 
    return sum; 
}
```

## Test List

```csharp
Debug.Assert(CalSum(9) == 49);
```

```csharp
Debug.Assert(CalSum(10) == 66);
```

```csharp
Debug.Assert(CalSum(11) == 88);
```
