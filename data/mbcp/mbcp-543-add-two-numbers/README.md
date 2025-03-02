# mbcp543 -- Add two numbers and print digits of their sum

## Text

Write a function to add two numbers and print number of digits of sum.

## Code

```csharp
public int CountDigits(int num1, int num2) 
{
    int number = num1 + num2;
    int count = 0;
    while (number > 0) 
    {
        number = number / 10;
        count = count + 1;
    }
    return count;
}
```

## Test List

```csharp
Debug.Assert(CountDigits(9875, 10) == 4);
```

```csharp
Debug.Assert(CountDigits(98759853034, 100) == 11);
```

```csharp
Debug.Assert(CountDigits(1234567, 500) == 7);
```
