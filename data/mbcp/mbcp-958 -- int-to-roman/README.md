# mbcp-958 -- Convert an integer to its Roman numeral equivalent

## Text

Write a function to convert an integer into a roman numeral.

## Code

```csharp
public string IntToRoman(int num) {
    int[] val = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
    string[] syb = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
    string romanNum = string.Empty;
    int i = 0;
    while (num > 0) {
        for (int j = 0; j < num / val[i]; j++) {
            romanNum += syb[i];
            num -= val[i];
        }
        i++;
    }
    return romanNum;
}
```

## Test List

```csharp
Debug.Assert(IntToRoman(1) == "I");
```

```csharp
Debug.Assert(IntToRoman(50) == "L");
```

```csharp
Debug.Assert(IntToRoman(4) == "IV");
```
