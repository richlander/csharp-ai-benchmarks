# mbcp-98 -- Multiply list numbers and divide by list length

## Text

Write a function to multiply all the numbers in a list and divide with the length of the list.

## Code

```csharp
public static double MultiplyNum(List<int> numbers)  
{  
    double total = 1;  
    foreach (int x in numbers)  
    {  
        total *= x;  
    }  
    return total / numbers.Count;  
}
```

## Test List

```csharp
Debug.Assert(MultiplyNum(new double[] { 8, 2, 3, -1, 7 }) == -67.2);
```

```csharp
Debug.Assert(MultiplyNum(-10, -20, -30) == -2000.0);
```

```csharp
Debug.Assert(MultiplyNum(new Tuple<int, int, int>(19, 15, 18)) == 1710.0);
```
