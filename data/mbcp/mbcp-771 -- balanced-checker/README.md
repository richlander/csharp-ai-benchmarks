# mbcp-771 -- Check if the expression has balanced brackets

## Text

Write a function to check if the given expression is balanced or not.

## Code

```csharp
using System.Collections.Generic;

public class ExpressionChecker
{
    public static bool CheckExpression(string exp)
    {
        if (exp.Length % 2 != 0)
        {
            return false;
        }
        
        Stack<char> stack = new Stack<char>();
        
        foreach (char ch in exp)
        {
            if (ch == '(' || ch == '{' || ch == '[')
            {
                stack.Push(ch);
            }
            if (ch == ')' || ch == '}' || ch == ']')
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                char top = stack.Pop();
                if ((top == '(' && ch != ')') || (top == '{' && ch != '}') || (top == '[' && ch != ']'))
                {
                    return false;
                }
            }
        }
        
        return stack.Count == 0;
    }
}
```

## Test List

```csharp
Debug.Assert(CheckExpression("{()}[{}]") == true);
```

```csharp
Debug.Assert(CheckExpression("{()}[{]") == false);
```

```csharp
Debug.Assert(CheckExpression("{()}[{}][]({})") == true);
```
