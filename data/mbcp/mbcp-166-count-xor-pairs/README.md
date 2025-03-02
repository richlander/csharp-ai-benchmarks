# mbcp166 -- Count pairs with even XOR in a list

## Text

Write a C# function to count the pairs with xor as an even number.

## Code

```csharp
public int FindEvenPair(int[] A, int N) 
{
    int evenPair = 0;
    for (int i = 0; i < N; i++) 
    {
        for (int j = i + 1; j < N; j++) 
        {
            if ((A[i] ^ A[j]) % 2 == 0) 
            {
                evenPair++;
            }
        }
    }
    return evenPair;
}
```

## Test List

```csharp
Debug.Assert(FindEvenPair(new int[] { 5, 4, 7, 2, 1 }, 5) == 4);
```

```csharp
Debug.Assert(FindEvenPair(new int[] { 7, 2, 8, 1, 0, 5, 11 }, 7) == 9);
```

```csharp
Debug.Assert(FindEvenPair(new int[] { 1, 2, 3 }, 3) == 1);
```
