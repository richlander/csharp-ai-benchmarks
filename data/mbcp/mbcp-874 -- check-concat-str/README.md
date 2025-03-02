# mbcp-874 -- Check if a string is a concatenation of another string

## Text

Write a C# function to check if the string is a concatenation of another string.

## Code

```csharp
public bool CheckConcat(string str1, string str2) {
    int N = str1.Length;
    int M = str2.Length;
    if (N % M != 0) {
        return false;
    }
    for (int i = 0; i < N; i++) {
        if (str1[i] != str2[i % M]) {
            return false;
        }
    }
    return true;
}
```

## Test List

```csharp
Debug.Assert(CheckConcat("abcabcabc", "abc") == true);
```

```csharp
Debug.Assert(CheckConcat("abcab", "abc") == false);
```

```csharp
Debug.Assert(CheckConcat("aba", "ab") == false);
```
