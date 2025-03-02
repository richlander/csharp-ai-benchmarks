# mbcp-172 -- Count occurrences of 'std' in a string

## Text

Write a function to find the occurence of characters 'std' in the given string 1. list item 1. list item 1. list item 2. list item 2. list item 2. list item

## Code

```csharp
public int CountOccurance(string s) {
    int count = 0;
    for (int i = 0; i < s.Length - 2; i++) {
        if (s[i] == 's' && s[i + 1] == 't' && s[i + 2] == 'd') {
            count++;
        }
    }
    return count;
}
```

## Test List

```csharp
Debug.Assert(CountOccurance("letstdlenstdporstd") == 3);
```

```csharp
Debug.Assert(CountOccurance("truststdsolensporsd") == 1);
```

```csharp
Debug.Assert(CountOccurance("makestdsostdworthit") == 2);
```
