# mbcp-866 -- Check if month has 31 days based on name

## Text

Write a function to check whether the given month name contains 31 days or not.

## Code

```csharp
public bool CheckMonthNumb(string monthname2)
{
    if (monthname2 == "January" || monthname2 == "March" || monthname2 == "May" || monthname2 == "July" || monthname2 == "August" || monthname2 == "October" || monthname2 == "December")
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
Debug.Assert(CheckMonthNumb("February") == false);
```

```csharp
Debug.Assert(CheckMonthNumb("January") == true);
```

```csharp
Debug.Assert(CheckMonthNumb("March") == true);
```
