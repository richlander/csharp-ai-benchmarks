# mbcp-669 -- Validate IP address format using regex function

## Text

Write a function to check whether the given ip address is valid or not using regex.

## Code

```csharp
using System.Text.RegularExpressions;

public class IpValidator
{
    private static readonly string regex = @"^(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)\." +
                                            @"(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)\." +
                                            @"(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)\." +
                                            @"(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)$";

    public static string CheckIP(string Ip)
    {
        if (Regex.IsMatch(Ip, regex))
        {
            return "Valid IP address";
        }
        else
        {
            return "Invalid IP address";
        }
    }
}
```

## Test List

```csharp
Debug.Assert(CheckIP("192.168.0.1") == "Valid IP address");
```

```csharp
Debug.Assert(CheckIP("110.234.52.124") == "Valid IP address");
```

```csharp
Debug.Assert(CheckIP("366.1.2.2") == "Invalid IP address");
```
