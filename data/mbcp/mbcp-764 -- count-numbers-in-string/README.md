# mbcp-764 -- Count numeric values in a string with Python function

## Text

Write a C# function to count numeric values in a given string.

## Code

```csharp
public int NumberCtr(string str) {
    int numberCtr = 0;
    for (int i = 0; i < str.Length; i++) {
        if (str[i] >= '0' && str[i] <= '9') numberCtr++;
    }
    return numberCtr;
}
```

## Test List

```csharp
Debug.Assert(NumberCtr("program2bedone") == 1);
```

```csharp
Debug.Assert(NumberCtr("3wonders") == 1);
```

```csharp
Debug.Assert(NumberCtr("123") == 3);
```
