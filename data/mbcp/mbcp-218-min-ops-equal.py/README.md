# mbcp218 -- Find minimum operations to equal two numbers

## Text

Write a C# function to find the minimum operations required to make two numbers equal.

## Code

```csharp
public int MinOperations(int A, int B)  
{  
    if (A > B)  
    {  
        int temp = A;  
        A = B;  
        B = temp;  
    }  
    B = B / Gcd(A, B);  
    return B - 1;  
}  

private int Gcd(int a, int b)  
{  
    while (b != 0)  
    {  
        int temp = b;  
        b = a % b;  
        a = temp;  
    }  
    return a;  
}
```

## Test List

```csharp
Debug.Assert(MinOperations(2, 4) == 1);
```

```csharp
Debug.Assert(MinOperations(4, 10) == 4);
```

```csharp
Debug.Assert(MinOperations(1, 4) == 3);
```
