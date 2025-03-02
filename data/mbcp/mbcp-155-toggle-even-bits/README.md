# mbcp155 -- Toggle even bits of a number using Python function

## Text

Write a C# function to toggle all even bits of a given number.

## Code

```csharp
public static int EvenBitToggleNumber(int n) 
{ 
    int res = 0; 
    int count = 0; 
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
    return n ^ res; 
}
```

## Test List

```csharp
Debug.Assert(EvenBitToggleNumber(10) == 0);
```

```csharp
Debug.Assert(EvenBitToggleNumber(20) == 30);
```

```csharp
Debug.Assert(EvenBitToggleNumber(30) == 20);
```
