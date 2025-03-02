# mbcp383 -- Toggle all odd bits in a given number using Python

## Text

Write a C# function to toggle all odd bits of a given number.

## Code

```csharp
public static int EvenBitToggleNumber(int n) 
{ 
    int res = 0; 
    int count = 0; 
    int temp = n; 
    while (temp > 0) 
    { 
        if (count % 2 == 0) 
        { 
            res |= (1 << count); 
        } 
        count++; 
        temp >>= 1; 
    } 
    return n ^ res; 
}
```

## Test List

```csharp
Debug.Assert(EvenBitToggleNumber(10) == 15);
```

```csharp
Debug.Assert(EvenBitToggleNumber(20) == 1);
```

```csharp
Debug.Assert(EvenBitToggleNumber(30) == 11);
```
