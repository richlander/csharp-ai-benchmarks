# mbcp820 -- Check if a month number has 28 days

## Text

Write a function to check whether the given month number contains 28 days or not.

## Code

```csharp
public bool CheckMonthNumNumber(int monthnum1)  
{  
    if (monthnum1 == 2)  
    {  
        return true;  
    }  
    else  
    {  
        return false;  
    }  
}
```

## Test List

```csharp
Debug.Assert(CheckMonthNumNumber(2) == true);
```

```csharp
Debug.Assert(CheckMonthNumNumber(1) == false);
```

```csharp
Debug.Assert(CheckMonthNumNumber(3) == false);
```
