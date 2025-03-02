# mbcp-227 -- Find the minimum value among three numbers

## Text

Write a function to find minimum of three numbers.

## Code

```csharp
public static int MinOfThree(int a, int b, int c) 
{
    int smallest;
    if ((a <= b) && (a <= c)) 
    {
        smallest = a; 
    } 
    else if ((b <= a) && (b <= c)) 
    {
        smallest = b; 
    } 
    else 
    {
        smallest = c; 
    }
    return smallest; 
}
```

## Test List

```csharp
Debug.Assert(MinOfThree(10, 20, 0) == 0);
```

```csharp
Debug.Assert(MinOfThree(19, 15, 18) == 15);
```

```csharp
Debug.Assert(MinOfThree(-10, -20, -30) == -30);
```
