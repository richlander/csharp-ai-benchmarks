# mbcp435 -- Find the last digit of a given number in Python

## Text

Write a C# function to find the last digit of a given number.

## Code

```csharp
public int Last_Digit(int n) 
{
    return n % 10; 
}
```

## Test List

```csharp
Debug.Assert(Last_Digit(123) == 3);
```

```csharp
Debug.Assert(Last_Digit(25) == 5);
```

```csharp
Debug.Assert(Last_Digit(30) == 0);
```
