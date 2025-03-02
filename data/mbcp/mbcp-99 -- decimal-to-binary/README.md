# mbcp-99 -- Convert decimal to binary using a function

## Text

Write a function to convert the given decimal number to its binary equivalent.

## Code

```csharp
public static string DecimalToBinary(int n) 
{ 
    return Convert.ToString(n, 2); 
}
```

## Test List

```csharp
Debug.Assert(DecimalToBinary(8) == "1000");
```

```csharp
Debug.Assert(DecimalToBinary(18) == "10010");
```

```csharp
Debug.Assert(DecimalToBinary(7) == "111");
```
