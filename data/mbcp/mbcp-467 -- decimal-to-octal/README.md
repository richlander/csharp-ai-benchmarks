# mbcp-467 -- Convert decimal to octal using a Python function

## Text

Write a C# function to convert decimal number to octal number.

## Code

```csharp
public int DecimalToOctal(int deciNum) {
    int octalNum = 0;
    int countval = 1;
    int dNo = deciNum;
    while (deciNum != 0) {
        int remainder = deciNum % 8;
        octalNum += remainder * countval;
        countval *= 10;
        deciNum /= 8;
    }
    return octalNum;
}
```

## Test List

```csharp
Debug.Assert(DecimalToOctal(10) == 12);
```

```csharp
Debug.Assert(DecimalToOctal(2) == 2);
```

```csharp
Debug.Assert(DecimalToOctal(33) == 41);
```
