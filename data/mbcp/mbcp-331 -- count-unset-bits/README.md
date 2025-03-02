# mbcp-331 -- Count unset bits in a given number using Python

## Text

Write a C# function to count unset bits of a given number.

## Code

```csharp
public int CountUnsetBits(int n) 
{ 
    int count = 0; 
    int x = 1; 
    while (x < n + 1) 
    { 
        if ((x & n) == 0) 
        { 
            count += 1; 
        } 
        x <<= 1; 
    } 
    return count; 
}
```

## Test List

```csharp
Debug.Assert(CountUnsetBits(2) == 1);
```

```csharp
Debug.Assert(CountUnsetBits(4) == 2);
```

```csharp
Debug.Assert(CountUnsetBits(6) == 1);
```
