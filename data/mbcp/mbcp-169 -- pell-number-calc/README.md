# mbcp-169 -- Calculate the nth Pell number using a function

## Text

Write a function to calculate the nth pell number.

## Code

```csharp
public static int GetPell(int n) 
{ 
    if (n <= 2) 
    { 
        return n; 
    } 
    int a = 1; 
    int b = 2; 
    for (int i = 3; i <= n; i++) 
    { 
        int c = 2 * b + a; 
        a = b; 
        b = c; 
    } 
    return b; 
}
```

## Test List

```csharp
Debug.Assert(GetPell(4) == 12);
```

```csharp
Debug.Assert(GetPell(7) == 169);
```

```csharp
Debug.Assert(GetPell(8) == 408);
```
