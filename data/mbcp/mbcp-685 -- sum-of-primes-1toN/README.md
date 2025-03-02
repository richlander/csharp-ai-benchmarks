# mbcp-685 -- Sum of prime numbers from 1 to n in Python

## Text

Write a C# function to find sum of prime numbers between 1 to n.

## Code

```csharp
public int SumOfPrimes(int n)  
{  
    bool[] prime = new bool[n + 1];  
    for (int i = 0; i <= n; i++)  
        prime[i] = true;  
    int p = 2;  
    while (p * p <= n)  
    {  
        if (prime[p])  
        {  
            for (int i = p * 2; i <= n; i += p)  
                prime[i] = false;  
        }  
        p++;  
    }  
    int sum = 0;  
    for (int i = 2; i <= n; i++)  
    {  
        if (prime[i])  
            sum += i;  
    }  
    return sum;  
}
```

## Test List

```csharp
Debug.Assert(SumOfPrimes(10) == 17);
```

```csharp
Debug.Assert(SumOfPrimes(20) == 77);
```

```csharp
Debug.Assert(SumOfPrimes(5) == 10);
```
