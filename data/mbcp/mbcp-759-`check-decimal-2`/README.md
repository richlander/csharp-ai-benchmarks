# mbcp759 -- Check decimal values for two decimal precision

## Text

Write a function to check a decimal with a precision of 2.

## Code

```csharp
public bool IsDecimal(string num) 
{
    var dnumre = new System.Text.RegularExpressions.Regex(@"^[0-9]+(\.[0-9]{1,2})?$");
    var result = dnumre.IsMatch(num);
    return result;
}
```

## Test List

```csharp
Debug.Assert(IsDecimal("123.11") == true);
```

```csharp
Debug.Assert(IsDecimal("e666.86") == false);
```

```csharp
Debug.Assert(IsDecimal("3.124587") == false);
```
