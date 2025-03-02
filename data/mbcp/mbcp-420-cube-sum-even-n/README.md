# mbcp420 -- Cube sum of first n even natural numbers

## Text

Write a C# function to find the cube sum of first n even natural numbers.

## Code

```csharp
public int CubeSum(int n) 
{ 
    int sum = 0; 
    for (int i = 1; i <= n; i++) 
    { 
        sum += (2 * i) * (2 * i) * (2 * i); 
    } 
    return sum; 
}
```

## Test List

```csharp
Debug.Assert(CubeSum(2) == 72);
```

```csharp
Debug.Assert(CubeSum(3) == 288);
```

```csharp
Debug.Assert(CubeSum(4) == 800);
```
