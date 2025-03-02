# mbcp575 -- Find the nth non-multiple of a given number

## Text

Write a C# function to find nth number in a sequence which is not a multiple of a given number.

## Code

```csharp
public int CountNo(int A, int N, int L, int R) 
{
    int count = 0;
    int i;
    for (i = L; i <= R; i++) 
    {
        if (i % A != 0) 
        {
            count++;
        }
        if (count == N) 
        {
            break;
        }
    }
    return i;
}
```

## Test List

```csharp
Debug.Assert(CountNo(2, 3, 1, 10) == 5);
```

```csharp
Debug.Assert(CountNo(3, 6, 4, 20) == 11);
```

```csharp
Debug.Assert(CountNo(5, 10, 4, 20) == 16);
```
