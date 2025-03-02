# mbcp-181 -- Find the longest common prefix in a list of strings

## Text

Write a function to find the longest common prefix in the given set of strings.

## Code

```csharp
string CommonPrefixUtil(string str1, string str2) 
{ 
    string result = ""; 
    int n1 = str1.Length; 
    int n2 = str2.Length; 
    int i = 0; 
    int j = 0; 
    while (i <= n1 - 1 && j <= n2 - 1) 
    { 
        if (str1[i] != str2[j]) 
            break; 
        result += str1[i]; 
        i++; 
        j++; 
    } 
    return result; 
} 

string CommonPrefix(string[] arr, int n) 
{ 
    string prefix = arr[0]; 
    for (int i = 1; i < n; i++) 
    { 
        prefix = CommonPrefixUtil(prefix, arr[i]); 
    } 
    return prefix; 
}
```

## Test List

```csharp
Debug.Assert(CommonPrefix(new string[] { "tablets", "tables", "taxi", "tamarind" }, 4) == "ta");
```

```csharp
Debug.Assert(CommonPrefix(new string[] { "apples", "ape", "april" }, 3) == "ap");
```

```csharp
Debug.Assert(CommonPrefix(new string[] { "teens", "teenager", "teenmar" }, 3) == "teen");
```
