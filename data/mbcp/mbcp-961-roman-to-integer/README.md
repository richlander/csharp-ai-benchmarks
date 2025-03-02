# mbcp961 -- Convert a roman numeral to its integer value

## Text

Write a function to convert a roman numeral to an integer.

## Code

```csharp
public int RomanToInt(string s) {
    var romVal = new Dictionary<char, int> {
        { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 },
        { 'C', 100 }, { 'D', 500 }, { 'M', 1000 }
    };
    int intVal = 0;
    for (int i = 0; i < s.Length; i++) {
        if (i > 0 && romVal[s[i]] > romVal[s[i - 1]]) {
            intVal += romVal[s[i]] - 2 * romVal[s[i - 1]];
        } else {
            intVal += romVal[s[i]];
        }
    }
    return intVal;
}
```

## Test List

```csharp
Debug.Assert(RomanToInt("MMMCMLXXXVI") == 3986);
```

```csharp
Debug.Assert(RomanToInt("MMMM") == 4000);
```

```csharp
Debug.Assert(RomanToInt("C") == 100);
```
