# mbcp-235 -- Set all even bits of a number using Python

## Text

Write a C# function to set all even bits of a given number.

## Code

```csharp
public static int EvenBitSetNumber(int n) 
{ 
    int count = 0; 
    int res = 0; 
    int temp = n; 
    
    while (temp > 0) 
    { 
        if (count % 2 == 1) 
        { 
            res |= (1 << count); 
        } 
        count++; 
        temp >>= 1; 
    } 
    
    return (n | res); 
}
```

## Test List

```csharp
Debug.Assert(EvenBitSetNumber(10) == 10);
```

```csharp
Debug.Assert(EvenBitSetNumber(20) == 30);
```

```csharp
Debug.Assert(EvenBitSetNumber(30) == 30);
```
