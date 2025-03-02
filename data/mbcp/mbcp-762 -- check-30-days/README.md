# mbcp-762 -- Check if a month has 30 days or not

## Text

Write a function to check whether the given month number contains 30 days or not.

## Code

```csharp
public bool CheckMonthNumberNumber(int monthnum3) 
{
    if (monthnum3 == 4 || monthnum3 == 6 || monthnum3 == 9 || monthnum3 == 11) 
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
Debug.Assert(CheckMonthNumberNumber(6) == true);
```

```csharp
Debug.Assert(CheckMonthNumberNumber(2) == false);
```

```csharp
Debug.Assert(CheckMonthNumberNumber(12) == false);
```
