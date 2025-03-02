# mbcp838 -- Find swaps to make two binary strings equal

## Text

Write a C# function to find minimum number swaps required to make two binary strings equal.

## Code

```csharp
public int MinSwaps(string s1, string s2)  
{  
    int c0 = 0, c1 = 0;  
    for (int i = 0; i < s1.Length; i++)  
    {  
        if (s1[i] == '0' && s2[i] == '1')  
        {  
            c0++;  
        }  
        else if (s1[i] == '1' && s2[i] == '0')  
        {  
            c1++;  
        }  
    }  
    int result = c0 / 2 + c1 / 2;  
    if (c0 % 2 == 0 && c1 % 2 == 0)  
    {  
        return result;  
    }  
    else if ((c0 + c1) % 2 == 0)  
    {  
        return result + 2;  
    }  
    else  
    {  
        return -1;  
    }  
}
```

## Test List

```csharp
Debug.Assert(MinSwaps("0011", "1111") == 1);
```

```csharp
Debug.Assert(MinSwaps("00011", "01001") == 2);
```

```csharp
Debug.Assert(MinSwaps("111", "111") == 0);
```
