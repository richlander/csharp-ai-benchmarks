# mbcp-343 -- Count digits and letters in a given string

## Text

Write a function to calculate the number of digits and letters in a string.

## Code

```csharp
public (int, int) DigLet(string s) 
{
    int d = 0, l = 0;
    foreach (char c in s) 
    {
        if (char.IsDigit(c)) 
        {
            d++;
        } 
        else if (char.IsLetter(c)) 
        {
            l++;
        } 
    }
    return (l, d);
}
```

## Test List

```csharp
Debug.Assert(DigLet("python").Equals((6, 0)));
```

```csharp
Debug.Assert(DigLet("program").Equals((7, 0)));
```

```csharp
Debug.Assert(DigLet("python3.0").Equals((6, 2)));
```
