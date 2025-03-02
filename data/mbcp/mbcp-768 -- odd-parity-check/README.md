# mbcp-768 -- Check if a number has odd parity in Python

## Text

Write a C# function to check for odd parity of a given number.

## Code

```csharp
public bool CheckOddParity(int x) 
{
    int parity = 0;
    while (x != 0) 
    {
        x = x & (x - 1);
        parity += 1;
    }
    return parity % 2 == 1;
}
```

## Test List

```csharp
Debug.Assert(CheckOddParity(13) == true);
```

```csharp
Debug.Assert(CheckOddParity(21) == true);
```

```csharp
Debug.Assert(CheckOddParity(18) == false);
```
