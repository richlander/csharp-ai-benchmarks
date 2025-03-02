# mbcp954 -- Calculate profit or return none if no profit

## Text

Write a function that gives profit amount if the given amount has profit else return none.

## Code

```csharp
public static double? ProfitAmount(double actualCost, double saleAmount) 
{ 
    if (actualCost > saleAmount) 
    { 
        double amount = actualCost - saleAmount; 
        return amount; 
    } 
    else 
    { 
        return null; 
    } 
}
```

## Test List

```csharp
Debug.Assert(ProfitAmount(1500, 1200) == 300);
```

```csharp
Debug.Assert(ProfitAmount(100, 200) == null);
```

```csharp
Debug.Assert(ProfitAmount(2000, 5000) == null);
```
