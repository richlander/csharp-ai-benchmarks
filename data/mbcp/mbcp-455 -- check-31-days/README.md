# mbcp-455 -- Check if a month has 31 days or not

## Text

Write a function to check whether the given month number contains 31 days or not.

## Code

```csharp
public bool CheckMonthNumbNumber(int monthnum2) {
    if (monthnum2 == 1 || monthnum2 == 3 || monthnum2 == 5 || monthnum2 == 7 || monthnum2 == 8 || monthnum2 == 10 || monthnum2 == 12) {
        return true;
    } else {
        return false;
    }
}
```

## Test List

```csharp
Debug.Assert(CheckMonthNumbNumber(5) == true);
```

```csharp
Debug.Assert(CheckMonthNumbNumber(2) == false);
```

```csharp
Debug.Assert(CheckMonthNumbNumber(6) == false);
```
