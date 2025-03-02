# mbcp-593 -- Remove leading zeroes from an IP address

## Text

Write a function to remove leading zeroes from an ip address.

## Code

```csharp
public string RemoveZeroIp(string ip)
{
    string result = Regex.Replace(ip, @"\.[0]*", ".");
    return result;
}
```

## Test List

```csharp
Debug.Assert(RemoveZeroIp("216.08.094.196") == "216.8.94.196");
```

```csharp
Debug.Assert(RemoveZeroIp("12.01.024") == "12.1.24");
```

```csharp
Debug.Assert(RemoveZeroIp("216.08.094.0196") == "216.8.94.196");
```
