# mbcp-203 -- Calculate Hamming distance between two integers

## Text

Write a C# function to find the hamming distance between given two integers.

## Code

```csharp
public int HammingDistance(int n1, int n2) 
{
    int x = n1 ^ n2;
    int setBits = 0;
    while (x > 0) 
    {
        setBits += x & 1;
        x >>= 1;
    }
    return setBits;
}
```

## Test List

```csharp
Debug.Assert(HammingDistance(4, 8) == 2);
```

```csharp
Debug.Assert(HammingDistance(2, 4) == 2);
```

```csharp
Debug.Assert(HammingDistance(1, 2) == 2);
```
