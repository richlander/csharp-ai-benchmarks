# mbcp175 -- Check if parentheses in a string are valid

## Text

Write a function to verify validity of a string of parentheses.

## Code

```csharp
public bool IsValidParenthese(string str1) {
    var stack = new Stack<char>();
    var pchar = new Dictionary<char, char> {
        { '(', ')' },
        { '{', '}' },
        { '[', ']' }
    };
    
    foreach (char parenthese in str1) {
        if (pchar.ContainsKey(parenthese)) {
            stack.Push(parenthese);
        } else if (stack.Count == 0 || pchar[stack.Pop()] != parenthese) {
            return false;
        }
    }
    return stack.Count == 0;
}
```

## Test List

```csharp
Debug.Assert(IsValidParenthese("(){}[]") == true);
```

```csharp
Debug.Assert(IsValidParenthese("()[{)}") == false);
```

```csharp
Debug.Assert(IsValidParenthese("()") == true);
```
