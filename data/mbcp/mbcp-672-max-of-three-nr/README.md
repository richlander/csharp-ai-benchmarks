# mbcp672 -- Find the maximum among three given numbers

## Text

Write a function to find maximum of three numbers.

## Code

```csharp
public int MaxOfThree(int num1, int num2, int num3) 
{
    int lnum;
    if (num1 >= num2 && num1 >= num3)
        lnum = num1;
    else if (num2 >= num1 && num2 >= num3)
        lnum = num2;
    else
        lnum = num3;
    return lnum;
}
```

## Test List

```csharp
Debug.Assert(MaxOfThree(10, 20, 30) == 30);

public int MaxOfThree(int a, int b, int c)
{
    return Math.Max(a, Math.Max(b, c));
}
```

```csharp
Debug.Assert(MaxOfThree(55, 47, 39) == 55);

public int MaxOfThree(int a, int b, int c)
{
    return Math.Max(a, Math.Max(b, c));
}
```

```csharp
Debug.Assert(MaxOfThree(10, 49, 30) == 49);

public int MaxOfThree(int a, int b, int c)
{
    return Math.Max(a, Math.Max(b, c));
}
```
