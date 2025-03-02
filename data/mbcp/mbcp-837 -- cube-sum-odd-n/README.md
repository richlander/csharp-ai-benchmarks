# mbcp-837 -- Calculate the cube sum of first n odd numbers

## Text

Write a C# function to find the cube sum of first n odd natural numbers.

## Code

```csharp
public int CubeSum(int n) 
{ 
    int sum = 0; 
    for (int i = 0; i < n; i++) 
    { 
        sum += (2 * i + 1) * (2 * i + 1) * (2 * i + 1); 
    } 
    return sum; 
}
```

## Test List

```csharp
Debug.Assert(CubeSum(2) == 28);
```

```csharp
Debug.Assert(CubeSum(3) == 153);
```

```csharp
Debug.Assert(CubeSum(4) == 496);
```
