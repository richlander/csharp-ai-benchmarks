# mbcp-812 -- Abbreviate road to rd in a given string

## Text

Write a function to abbreviate 'road' as 'rd.' in a given string.

## Code

```csharp
public string RoadRd(string street)  
{  
    return Regex.Replace(street, "Road$", "Rd.");  
}
```

## Test List

```csharp
Debug.Assert(RoadRd("ravipadu Road") == "ravipadu Rd.");
```

```csharp
Debug.Assert(RoadRd("palnadu Road") == "palnadu Rd.");
```

```csharp
Debug.Assert(RoadRd("eshwar enclave Road") == "eshwar enclave Rd.");
```
