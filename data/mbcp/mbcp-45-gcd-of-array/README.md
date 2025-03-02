# mbcp45 -- Find the gcd of array elements using a function

## Text

Write a function to find the gcd of the given array elements.

## Code

```csharp
public static int FindGcd(int x, int y) 
{
    while (y != 0) 
    {
        int temp = y;
        y = x % y;
        x = temp;
    }
    return x;
}

public static int GetGcd(List<int> l) 
{
    int num1 = l[0];
    int num2 = l[1];
    int gcd = FindGcd(num1, num2);
    
    for (int i = 2; i < l.Count; i++) 
    {
        gcd = FindGcd(gcd, l[i]);
    }
    
    return gcd;
}
```

## Test List

```csharp
Debug.Assert(GetGcd(new int[] { 2, 4, 6, 8, 16 }) == 2);
```

```csharp
Debug.Assert(GetGcd(new int[] { 1, 2, 3 }) == 1);
```

```csharp
Debug.Assert(GetGcd(new int[] { 2, 4, 6, 8 }) == 2);
```
