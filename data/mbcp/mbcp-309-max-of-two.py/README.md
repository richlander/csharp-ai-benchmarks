# mbcp309 -- Find the maximum of two numbers in Python

## Text

Write a C# function to find the maximum of two numbers.

## Code

```csharp
public static int Maximum(int a, int b)  
{  
    if (a >= b)  
        return a;  
    else  
        return b;  
}
```

## Test List

```csharp
Debug.Assert(Maximum(5, 10) == 10);
```

```csharp
Debug.Assert(Maximum(-1, -2) == -1);
```

```csharp
Debug.Assert(Maximum(9, 7) == 9);
```
