# mbcp479 -- Find the first digit of a given number in Python

## Text

Write a C# function to find the first digit of a given number.

## Code

```csharp
public int FirstDigit(int n)  
{  
    while (n >= 10)  
    {  
        n = n / 10;  
    }  
    return n;  
}
```

## Test List

```csharp
Debug.Assert(FirstDigit(123) == 1);
```

```csharp
Debug.Assert(FirstDigit(456) == 4);
```

```csharp
Debug.Assert(FirstDigit(12) == 1);
```
