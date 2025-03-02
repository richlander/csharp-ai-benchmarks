# mbcp-395 -- Find the first unique character in a string

## Text

Write a C# function to find the first non-repeated character in a given string.

## Code

```csharp
public static char? FirstNonRepeatingCharacter(string str1) {
    List<char> charOrder = new List<char>();
    Dictionary<char, int> ctr = new Dictionary<char, int>();
    foreach (char c in str1) {
        if (ctr.ContainsKey(c)) {
            ctr[c]++;
        } else {
            ctr[c] = 1;
            charOrder.Add(c);
        }
    }
    foreach (char c in charOrder) {
        if (ctr[c] == 1) {
            return c;
        }
    }
    return null;
}
```

## Test List

```csharp
Debug.Assert(FirstNonRepeatingCharacter("abcabc") == null);
```

```csharp
Debug.Assert(FirstNonRepeatingCharacter("abc") == "a");
```

```csharp
Debug.Assert(FirstNonRepeatingCharacter("ababc") == "c");
```
