# mbcp-855 -- Check if a number has even parity in Python

## Text

Write a C# function to check for even parity of a given number.

## Code

```csharp
public bool CheckEvenParity(int x) 
{ 
    int parity = 0; 
    while (x != 0) 
    { 
        x = x & (x - 1); 
        parity += 1; 
    } 
    return parity % 2 == 0; 
}
```

## Test List

```csharp
Debug.Assert(CheckEvenParity(10) == true);
```

```csharp
Debug.Assert(CheckEvenParity(11) == false);
```

```csharp
Debug.Assert(CheckEvenParity(18) == true);
```
