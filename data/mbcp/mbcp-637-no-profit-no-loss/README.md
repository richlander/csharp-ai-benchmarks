# mbcp637 -- Function to check zero profit or loss

## Text

Write a function to check whether the given amount has no profit and no loss

## Code

```csharp
public bool NoProfitNoLoss(decimal actualCost, decimal saleAmount) 
{ 
    return saleAmount == actualCost; 
}
```

## Test List

```csharp
Debug.Assert(NoProfitNoLoss(1500, 1200) == false);
```

```csharp
Debug.Assert(NoProfitNoLoss(100, 100) == true);
```

```csharp
Debug.Assert(NoProfitNoLoss(2000, 5000) == false);
```
