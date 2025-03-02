# mbcp-595 -- Count swaps to convert one binary string to another

## Text

Write a C# function to count minimum number of swaps required to convert one binary string to another.

## Code

```csharp
public string MinSwaps(string str1, string str2) 
{ 
    int count = 0; 
    for (int i = 0; i < str1.Length; i++) 
    { 
        if (str1[i] != str2[i]) 
        { 
            count++; 
        } 
    } 
    if (count % 2 == 0) 
    { 
        return (count / 2).ToString(); 
    } 
    else 
    { 
        return "Not Possible"; 
    } 
}
```

## Test List

```csharp
Debug.Assert(MinSwaps("1101", "1110") == 1);
```

```csharp
Debug.Assert(MinSwaps("111", "000") == "Not Possible");
```

```csharp
Debug.Assert(MinSwaps("111", "110") == "Not Possible");
```
