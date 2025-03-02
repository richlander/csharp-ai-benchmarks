# mbcp-711 -- Check if products of even and odd digit positions match

## Text

Write a C# function to check whether the product of digits of a number at even and odd places is equal or not.

## Code

```csharp
bool ProductEqual(int n) 
{ 
    if (n < 10) 
    { 
        return false; 
    } 
    int prodOdd = 1; 
    int prodEven = 1; 
    while (n > 0) 
    { 
        int digit = n % 10; 
        prodOdd *= digit; 
        n /= 10; 
        if (n == 0) 
        { 
            break; 
        } 
        digit = n % 10; 
        prodEven *= digit; 
        n /= 10; 
    } 
    return prodOdd == prodEven; 
}
```

## Test List

```csharp
Debug.Assert(ProductEqual(2841) == true);
```

```csharp
Debug.Assert(ProductEqual(1234) == false);
```

```csharp
Debug.Assert(ProductEqual(1212) == false);
```
