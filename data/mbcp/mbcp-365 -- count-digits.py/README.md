# mbcp-365 -- Count the digits in a given number using Python

## Text

Write a C# function to count the number of digits of a given number.

## Code

```csharp
public int CountDigit(int n) {
    int count = 0;
    while (n != 0) {
        n /= 10;
        count += 1;
    }
    return count;
}
```

## Test List

```csharp
Debug.Assert(CountDigit(12345) == 5);
```

```csharp
Debug.Assert(CountDigit(11223305) == 8);
```

```csharp
Debug.Assert(CountDigit(4123459) == 7);
```
