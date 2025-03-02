# mbcp-452 -- Calculate loss amount or return none if no loss

## Text

Write a function that gives loss amount if the given amount has loss else return none.

## Code

```csharp
public static double? LossAmount(double actualCost, double saleAmount) 
{ 
    if (saleAmount > actualCost) 
    { 
        double amount = saleAmount - actualCost; 
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
Debug.Assert(LossAmount(1500, 1200) == null);
```

```csharp
Debug.Assert(LossAmount(100, 200) == 100);
```

```csharp
Debug.Assert(LossAmount(2000, 5000) == 3000);
```
