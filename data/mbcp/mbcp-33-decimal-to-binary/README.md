# mbcp33 -- Convert a decimal number to binary format in Python

## Text

Write a C# function to convert a decimal number to binary number.

## Code

```csharp
public static int DecimalToBinary(int N) 
{ 
    int B_Number = 0; 
    int cnt = 0; 
    while (N != 0) 
    { 
        int rem = N % 2; 
        int c = (int)Math.Pow(10, cnt); 
        B_Number += rem * c; 
        N /= 2; 
        cnt++; 
    } 
    return B_Number; 
}
```

## Test List

```csharp
Debug.Assert(DecimalToBinary(10) == 1010);
```

```csharp
Debug.Assert(DecimalToBinary(1) == 1);
```

```csharp
Debug.Assert(DecimalToBinary(20) == 10100);
```
