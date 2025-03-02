# mbcp546 -- Find the last index of a character in a string

## Text

Write a function to find the last occurrence of a character in a string.

## Code

```csharp
public int? LastOccurenceChar(string str, char ch) {
    int flag = -1;
    for (int i = 0; i < str.Length; i++) {
        if (str[i] == ch) {
            flag = i;
        }
    }
    if (flag == -1) {
        return null;
    } else {
        return flag + 1;
    }
}
```

## Test List

```csharp
Debug.Assert(LastOccurenceChar("hello world", 'l') == 10);
```

```csharp
Debug.Assert(LastOccurenceChar("language", 'g') == 7);
```

```csharp
Debug.Assert(LastOccurenceChar("little", 'y') == null);
```
