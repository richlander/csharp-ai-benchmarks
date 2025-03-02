# mbcp-191 -- Check if month has 30 days or not

## Text

Write a function to check whether the given month name contains 30 days or not.

## Code

```csharp
public bool CheckMonthNumber(string monthName3)
{
    if (monthName3 == "April" || monthName3 == "June" || monthName3 == "September" || monthName3 == "November")
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
Debug.Assert(CheckMonthNumber("February") == false);
```

```csharp
Debug.Assert(CheckMonthNumber("June") == true);
```

```csharp
Debug.Assert(CheckMonthNumber("April") == true);
```
