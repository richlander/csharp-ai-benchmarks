# mbcp-48 -- Set all odd bits in a given number using Python

## Text

Write a C# function to set all odd bits of a given number.

## Code

```csharp
public int OddBitSetNumber(int n) {
    int count = 0;
    int res = 0;
    int temp = n;
    while (temp > 0) {
        if (count % 2 == 0) {
            res |= (1 << count);
        }
        count++;
        temp >>= 1;
    }
    return (n | res);
}
```

## Test List

```csharp
Debug.Assert(OddBitSetNumber(10) == 15);
```

```csharp
Debug.Assert(OddBitSetNumber(20) == 21);
```

```csharp
Debug.Assert(OddBitSetNumber(30) == 31);
```
