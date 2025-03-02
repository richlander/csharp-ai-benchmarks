# mbcp-107 -- Count hexadecimal numbers within a specified range

## Text

Write a C# function to count hexadecimal numbers for a given range.

## Code

```csharp
public int CountHexadecimal(int L, int R)  
{  
    int count = 0;  
    for (int i = L; i <= R; i++)  
    {  
        if (i >= 10 && i <= 15)  
        {  
            count++;  
        }  
        else if (i > 15)  
        {  
            int k = i;  
            while (k != 0)  
            {  
                if (k % 16 >= 10)  
                {  
                    count++;  
                }  
                k /= 16;  
            }  
        }  
    }  
    return count;  
}
```

## Test List

```csharp
Debug.Assert(CountHexadecimal(10, 15) == 6);
```

```csharp
Debug.Assert(CountHexadecimal(2, 4) == 0);
```

```csharp
Debug.Assert(CountHexadecimal(15, 16) == 1);
```
