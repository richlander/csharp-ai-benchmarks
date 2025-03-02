# mbcp776 -- Count characters with vowel neighbors in a string

## Text

Write a function to count those characters which have vowels as their neighbors in the given string.

## Code

```csharp
public int CountVowels(string testStr) {
    int res = 0;
    char[] vowList = { 'a', 'e', 'i', 'o', 'u' };
    for (int idx = 1; idx < testStr.Length - 1; idx++) {
        if (!vowList.Contains(testStr[idx]) && (vowList.Contains(testStr[idx - 1]) || vowList.Contains(testStr[idx + 1]))) {
            res++;
        }
    }
    if (!vowList.Contains(testStr[0]) && vowList.Contains(testStr[1])) {
        res++;
    }
    if (!vowList.Contains(testStr[testStr.Length - 1]) && vowList.Contains(testStr[testStr.Length - 2])) {
        res++;
    }
    return res;
}
```

## Test List

```csharp
Debug.Assert(CountVowels("bestinstareels") == 7);
```

```csharp
Debug.Assert(CountVowels("partofthejourneyistheend") == 12);
```

```csharp
Debug.Assert(CountVowels("amazonprime") == 5);
```
