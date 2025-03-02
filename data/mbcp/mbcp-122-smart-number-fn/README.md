# mbcp122 -- Find the n’th smart number efficiently

## Text

Write a function to find n’th smart number.

## Code

```csharp
const int MAX = 3000; 

public int SmartNumber(int n) 
{
    int[] primes = new int[MAX]; 
    List<int> result = new List<int>(); 
    
    for (int i = 2; i < MAX; i++) 
    {
        if (primes[i] == 0) 
        {
            primes[i] = 1; 
            int j = i * 2; 
            while (j < MAX) 
            {
                primes[j]--; 
                if (primes[j] + 3 == 0) 
                {
                    result.Add(j); 
                }
                j += i; 
            }
        }
    }
    
    result.Sort(); 
    return result[n - 1]; 
}
```

## Test List

```csharp
Debug.Assert(smartNumber(1) == 30);
```

```csharp
Debug.Assert(smartNumber(50) == 273);
```

```csharp
Debug.Assert(SmartNumber(1000) == 2664);
```
