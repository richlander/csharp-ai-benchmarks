# mbcp903 -- Count unset bits from 1 to n in Python

## Text

Write a C# function to count the total unset bits from 1 to n.

## Code

```csharp
public int CountUnsetBits(int n)  
{  
    int cnt = 0;  
    for (int i = 1; i <= n; i++)  
    {  
        int temp = i;  
        while (temp != 0)  
        {  
            if (temp % 2 == 0)  
            {  
                cnt++;  
            }  
            temp /= 2;  
        }  
    }  
    return cnt;  
}
```

## Test List

```csharp
Debug.Assert(CountUnsetBits(2) == 1);
```

```csharp
Debug.Assert(CountUnsetBits(5) == 4);
```

```csharp
Debug.Assert(CountUnsetBits(14) == 17);
```
