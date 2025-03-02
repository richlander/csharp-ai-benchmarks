# mbcp-422 -- Calculate the average of cubes of first n numbers

## Text

Write a C# function to find the average of cubes of first n natural numbers.

## Code

```csharp
public double FindAverageOfCube(int n)  
{  
    double sum = 0;  
    for (int i = 1; i <= n; i++)  
    {  
        sum += i * i * i;  
    }  
    return Math.Round(sum / n, 6);  
}
```

## Test List

```csharp
Debug.Assert(FindAverageOfCube(2) == 4.5);
```

```csharp
Debug.Assert(FindAverageOfCube(3) == 12);
```

```csharp
Debug.Assert(FindAverageOfCube(1) == 1);
```
