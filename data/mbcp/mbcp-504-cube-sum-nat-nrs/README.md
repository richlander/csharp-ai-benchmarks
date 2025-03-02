# mbcp504 -- Calculate the cube sum of first n natural numbers

## Text

Write a C# function to find the cube sum of first n natural numbers.

## Code

```csharp
public int SumOfSeries(int n) 
{ 
    int sum = 0; 
    for (int i = 1; i <= n; i++) 
    { 
        sum += i * i * i; 
    } 
    return sum; 
}
```

## Test List

```csharp
Debug.Assert(SumOfSeries(5) == 225);
```

```csharp
Debug.Assert(SumOfSeries(2) == 9);
```

```csharp
Debug.Assert(SumOfSeries(3) == 36);
```
