# mbcp547 -- Sum Hamming distances of consecutive numbers from 0 to n

## Text

Write a C# function to find the sum of hamming distances of all consecutive numbers from o to n.

## Code

```csharp
public static int TotalHammingDistance(int n)  
{  
    int i = 1;  
    int sum = 0;  
    while (n / i > 0)  
    {  
        sum += n / i;  
        i *= 2;  
    }  
    return sum;  
}
```

## Test List

```csharp
Debug.Assert(TotalHammingDistance(4) == 7);
```

```csharp
Debug.Assert(TotalHammingDistance(2) == 3);
```

```csharp
Debug.Assert(TotalHammingDistance(5) == 8);
```
