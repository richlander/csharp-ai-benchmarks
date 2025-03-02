# mbcp-179 -- Determine if a number is a keith number

## Text

Write a function to find if the given number is a keith number or not.

## Code

```csharp
bool IsNumKeith(int x) 
{
    List<int> terms = new List<int>(); 
    int temp = x; 
    int n = 0; 
    while (temp > 0) 
    { 
        terms.Add(temp % 10); 
        temp = temp / 10; 
        n++; 
    } 
    terms.Reverse(); 
    int nextTerm = 0; 
    int i = n; 
    while (nextTerm < x) 
    { 
        nextTerm = 0; 
        for (int j = 1; j <= n; j++) 
        { 
            nextTerm += terms[i - j]; 
        } 
        terms.Add(nextTerm); 
        i++; 
    } 
    return (nextTerm == x); 
}
```

## Test List

```csharp
Debug.Assert(IsNumKeith(14) == true);
```

```csharp
Debug.Assert(IsNumKeith(12) == false);
```

```csharp
Debug.Assert(IsNumKeith(197) == true);
```
