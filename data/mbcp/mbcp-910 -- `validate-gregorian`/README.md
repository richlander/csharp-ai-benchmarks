# mbcp-910 -- Validate a Gregorian date with a function

## Text

Write a function to validate a gregorian date.

## Code

```csharp
using System;

public class DateChecker
{
    public static bool CheckDate(int m, int d, int y)
    {
        try
        {
            DateTime date = new DateTime(y, m, d);
            return true;
        }
        catch (ArgumentOutOfRangeException)
        {
            return false;
        }
    }
}
```

## Test List

```csharp
Debug.Assert(CheckDate(11, 11, 2002) == true);
```

```csharp
Debug.Assert(CheckDate(13, 11, 2002) == false);
```

```csharp
Debug.Assert(CheckDate("11", "11", "2002") == true);
```
