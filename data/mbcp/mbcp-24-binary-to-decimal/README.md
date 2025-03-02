# mbcp24 -- Convert a binary number to decimal value

## Text

Write a function to convert the given binary number to its decimal equivalent.

## Code

```csharp
public static int BinaryToDecimal(int binary) 
{ 
    int decimal = 0, i = 0; 
    while (binary != 0) 
    { 
        int dec = binary % 10; 
        decimal += dec * (int)Math.Pow(2, i); 
        binary /= 10; 
        i++; 
    } 
    return decimal; 
}
```

## Test List

```csharp
Debug.Assert(BinaryToDecimal(100) == 4);
```

```csharp
Debug.Assert(BinaryToDecimal(1011) == 11);
```

```csharp
Debug.Assert(BinaryToDecimal(1101101) == 109);
```
