# mbcp-242 -- Count total characters in a given string input

## Text

Write a function to count total characters in a string.

## Code

```csharp
public int CountCharac(string str1) {
    int total = 0;
    foreach (char i in str1) {
        total++;
    }
    return total;
}
```

## Test List

```csharp
Debug.Assert(CountCharac("python programming") == 18);
```

```csharp
Debug.Assert(CountCharac("language") == 8);
```

```csharp
Debug.Assert(CountCharac("words") == 5);
```
