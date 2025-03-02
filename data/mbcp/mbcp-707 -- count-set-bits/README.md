# mbcp-707 -- Count set bits in numbers from 1 to n

## Text

Write a C# function to count the total set bits from 1 to n.

## Code

```csharp
public static int CountSetBits(int n)  
{  
    n += 1;  
    int powerOf2 = 2;  
    int cnt = n / 2;  
    while (powerOf2 <= n)  
    {  
        int totalPairs = n / powerOf2;  
        cnt += (totalPairs / 2) * powerOf2;  
        if ((totalPairs & 1) != 0)  
        {  
            cnt += (n % powerOf2);  
        }  
        powerOf2 <<= 1;  
    }  
    return cnt;  
}
```

## Test List

```csharp
Debug.Assert(CountSetBits(16) == 33);
```

```csharp
Debug.Assert(CountSetBits(2) == 2);
```

```csharp
Debug.Assert(CountSetBits(14) == 28);
```
