# mbcp-224 -- Count set bits in a number using Python function

## Text

Write a C# function to count set bits of a given number.

## Code

```csharp
public int CountSetBits(int n) 
{ 
    int count = 0; 
    while (n != 0) 
    { 
        count += n & 1; 
        n >>= 1; 
    } 
    return count; 
}
```

## Test List

```csharp
Debug.Assert(CountSetBits(2) == 1);
```

```csharp
Debug.Assert(CountSetBits(4) == 1);
```

```csharp
Debug.Assert(CountSetBits(6) == 2);
```
