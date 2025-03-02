# mbcp315 -- Find the longest even-length word in a string

## Text

Write a C# function to find the first maximum length of even word.

## Code

```csharp
public string FindMaxLenEven(string str) 
{ 
    int n = str.Length; 
    int i = 0; 
    int currlen = 0; 
    int maxlen = 0; 
    int st = -1; 

    while (i < n) 
    { 
        if (str[i] == ' ') 
        { 
            if (currlen % 2 == 0) 
            { 
                if (maxlen < currlen) 
                { 
                    maxlen = currlen; 
                    st = i - currlen; 
                } 
            } 
            currlen = 0; 
        } 
        else 
        { 
            currlen += 1; 
        } 
        i += 1; 
    } 

    if (currlen % 2 == 0) 
    { 
        if (maxlen < currlen) 
        { 
            maxlen = currlen; 
            st = i - currlen; 
        } 
    } 

    if (st == -1) 
    { 
        return "-1"; 
    } 
    return str.Substring(st, maxlen); 
}
```

## Test List

```csharp
Debug.Assert(FindMaxLenEven("python language") == "language");
```

```csharp
Debug.Assert(FindMaxLenEven("maximum even length") == "length");
```

```csharp
Debug.Assert(FindMaxLenEven("eve") == "-1");
```
