# mbcp-146 -- Find ASCII value of total string characters

## Text

Write a function to find the ascii value of total characters in a string.

## Code

```csharp
public int AsciiValueString(string str1) {
    for (int i = 0; i < str1.Length; i++) {
        return (int)str1[i];
    }
    return 0; // In case the string is empty
}
```

## Test List

```csharp
Debug.Assert(AsciiValueString("python") == 112);
```

```csharp
Debug.Assert(AsciiValueString("Program") == 80);
```

```csharp
Debug.Assert(AsciiValueString("Language") == 76);
```
