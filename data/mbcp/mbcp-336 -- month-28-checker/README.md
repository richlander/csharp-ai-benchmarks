# mbcp-336 -- Check if month name has 28 days

## Text

Write a function to check whether the given month name contains 28 days or not.

## Code

```csharp
public bool CheckMonthNum(string monthName1)  
{  
    if (monthName1 == "February")  
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
Debug.Assert(CheckMonthNum("February") == true);
```

```csharp
Debug.Assert(CheckMonthNum("January") == false);
```

```csharp
Debug.Assert(CheckMonthNum("March") == false);
```
