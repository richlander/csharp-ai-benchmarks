# mbcp-714 -- Count distinct prime factor powers in a number

## Text

Write a C# function to count the number of distinct power of prime factor of given number.

## Code

```csharp
public int CountFac(int n)  
{  
    int m = n;  
    int count = 0;  
    int i = 2;  
    while ((i * i) <= m)  
    {  
        int total = 0;  
        while (n % i == 0)  
        {  
            n /= i;  
            total += 1;  
        }  
        int temp = 0;  
        int j = 1;  
        while ((temp + j) <= total)  
        {  
            temp += j;  
            count += 1;  
            j += 1;  
        }  
        i += 1;  
    }  
    if (n != 1)  
    {  
        count += 1;  
    }  
    return count;  
}
```

## Test List

```csharp
Debug.Assert(CountFac(24) == 3);
```

```csharp
Debug.Assert(CountFac(12) == 2);
```

```csharp
Debug.Assert(CountFac(4) == 1);
```
