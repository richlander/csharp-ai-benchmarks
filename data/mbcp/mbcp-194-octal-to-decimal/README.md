# mbcp194 -- Convert octal numbers to decimal in Python

## Text

Write a C# function to convert octal number to decimal number.

## Code

```csharp
public int OctalToDecimal(int n)  
{  
    int num = n;  
    int decValue = 0;  
    int baseValue = 1;  
    int temp = num;  
    while (temp != 0)  
    {  
        int lastDigit = temp % 10;  
        temp /= 10;  
        decValue += lastDigit * baseValue;  
        baseValue *= 8;  
    }  
    return decValue;  
}
```

## Test List

```csharp
Debug.Assert(OctalToDecimal(25) == 21);
```

```csharp
Debug.Assert(OctalToDecimal(30) == 24);
```

```csharp
Debug.Assert(OctalToDecimal(40) == 32);
```
