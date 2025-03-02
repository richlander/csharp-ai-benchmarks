# mbcp520 -- Find the lcm of array elements in a function

## Text

Write a function to find the lcm of the given array elements.

## Code

```csharp
public int FindLcm(int num1, int num2) 
{
    int num, den;
    if (num1 > num2) 
    {
        num = num1;
        den = num2;
    } 
    else 
    {
        num = num2;
        den = num1;
    }
    int rem = num % den;
    while (rem != 0) 
    {
        num = den;
        den = rem;
        rem = num % den;
    }
    int gcd = den;
    int lcm = (num1 * num2) / gcd;
    return lcm;
}

public int GetLcm(List<int> l) 
{
    int num1 = l[0];
    int num2 = l[1];
    int lcm = FindLcm(num1, num2);
    for (int i = 2; i < l.Count; i++) 
    {
        lcm = FindLcm(lcm, l[i]);
    }
    return lcm;
}
```

## Test List

```csharp
Debug.Assert(GetLcm(new int[] { 2, 7, 3, 9, 4 }) == 252);
```

```csharp
Debug.Assert(GetLcm(new List<int> { 1, 2, 8, 3 }) == 24);
```

```csharp
Debug.Assert(GetLcm(new int[] { 3, 8, 4, 10, 5 }) == 120);
```
