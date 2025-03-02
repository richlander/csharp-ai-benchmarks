# mbcp257 -- Swap the values of two given numbers

## Text

Write a function to swap two numbers.

## Code

```csharp
public (int, int) SwapNumbers(int a, int b)  
{  
    int temp = a;  
    a = b;  
    b = temp;  
    return (a, b);  
}
```

## Test List

```csharp
Debug.Assert(SwapNumbers(10, 20).Equals((20, 10)));
```

```csharp
Debug.Assert(SwapNumbers(15, 17).Equals((17, 15)));
```

```csharp
Debug.Assert(SwapNumbers(100, 200).Equals((200, 100)));
```
