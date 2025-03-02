# mbcp675 -- Add two integers but return 20 if in range

## Text

Write a function to add two integers. however, if the sum is between the given range it will return 20.

## Code

```csharp
public int SumNums(int x, int y, int m, int n) 
{
    int sumNums = x + y;
    if (sumNums >= m && sumNums < n) 
    {
        return 20;
    } 
    else 
    {
        return sumNums;
    }
}
```

## Test List

```csharp
Debug.Assert(SumNums(2, 10, 11, 20) == 20);
```

```csharp
Debug.Assert(SumNums(15, 17, 1, 10) == 32);
```

```csharp
Debug.Assert(SumNums(10, 15, 5, 30) == 20);
```
