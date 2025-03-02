# mbcp-556 -- Count pairs with odd XOR in a list

## Text

Write a C# function to count the pairs with xor as an odd number.

## Code

```csharp
public int FindOddPair(int[] A, int N) 
{ 
    int oddPair = 0; 
    for (int i = 0; i < N; i++) 
    { 
        for (int j = i + 1; j < N; j++) 
        { 
            if ((A[i] ^ A[j]) % 2 != 0) 
            { 
                oddPair++; 
            } 
        } 
    } 
    return oddPair; 
}
```

## Test List

```csharp
Debug.Assert(FindOddPair(new int[] { 5, 4, 7, 2, 1 }, 5) == 6);
```

```csharp
Debug.Assert(FindOddPair(new int[] { 7, 2, 8, 1, 0, 5, 11 }, 7) == 12);
```

```csharp
Debug.Assert(FindOddPair(new int[] { 1, 2, 3 }, 3) == 2);
```
