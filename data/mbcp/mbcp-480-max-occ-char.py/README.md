# mbcp480 -- Find the most frequent character in a string

## Text

Write a C# function to find the maximum occurring character in a given string.

## Code

```csharp
public static char GetMaxOccuringChar(string str1)
{
    const int ASCII_SIZE = 256;
    int[] ctr = new int[ASCII_SIZE];
    int max = -1;
    char ch = '\0';

    foreach (char i in str1)
    {
        ctr[i]++;
    }

    foreach (char i in str1)
    {
        if (max < ctr[i])
        {
            max = ctr[i];
            ch = i;
        }
    }

    return ch;
}
```

## Test List

```csharp
Debug.Assert(GetMaxOccuringChar("data") == "a");
```

```csharp
Debug.Assert(GetMaxOccuringChar("create") == "e");
```

```csharp
Debug.Assert(GetMaxOccuringChar("brilliant girl") == "i");
```
