# mbcp-545 -- Toggle first and last bits of a number in Python

## Text

Write a C# function to toggle only first and last bits of a given number.

## Code

```csharp
int TakeLAndFSetBits(int n) 
{ 
    n = n | (n >> 1); 
    n = n | (n >> 2); 
    n = n | (n >> 4); 
    n = n | (n >> 8); 
    n = n | (n >> 16); 
    return ((n + 1) >> 1) + 1; 
} 

int ToggleFAndLBits(int n) 
{ 
    if (n == 1) 
    { 
        return 0; 
    } 
    return n ^ TakeLAndFSetBits(n); 
}
```

## Test List

```csharp
Debug.Assert(ToggleFAndLBits(10) == 3);
```

```csharp
Debug.Assert(ToggleFAndLBits(15) == 6);
```

```csharp
Debug.Assert(ToggleFAndLBits(20) == 5);
```
