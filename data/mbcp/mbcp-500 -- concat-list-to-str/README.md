# mbcp-500 -- Concatenate list elements into a single string

## Text

Write a function to concatenate all elements of the given list into a string.

## Code

```csharp
public string ConcatenateElements(List<string> list) 
{
    string ans = " ";
    foreach (string i in list) 
    {
        ans += " " + i;
    }
    return ans;
}
```

## Test List

```csharp
Debug.Assert(ConcatenateElements(new string[] { "hello", "there", "have", "a", "rocky", "day" }) == "  hello there have a rocky day");
```

```csharp
Debug.Assert(ConcatenateElements(new string[] { "Hi", "there", "How", "are", "you" }) == "  Hi there How are you");
```

```csharp
Debug.Assert(ConcatenateElements(new string[] { "Part", "of", "the", "journey", "is", "end" }) == "  Part of the journey is end");
```
