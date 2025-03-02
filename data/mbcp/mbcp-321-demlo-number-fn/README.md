# mbcp321 -- Find the demlo number for a given input

## Text

Write a function to find the demlo number for the given number.

## Code

```csharp
public string FindDemlo(string s) 
{
    int l = s.Length;
    string res = "";
    for (int i = 1; i <= l; i++) 
    {
        res += i.ToString();
    }
    for (int i = l - 1; i > 0; i--) 
    {
        res += i.ToString();
    }
    return res;
}
```

## Test List

```csharp
Debug.Assert(FindDemlo("111111") == "12345654321");
```

```csharp
Debug.Assert(FindDemlo("1111") == "1234321");
```

```csharp
Debug.Assert(FindDemlo("13333122222") == "123456789101110987654321");
```
