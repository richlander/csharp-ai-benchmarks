# mbcp909 -- Find the largest palindrome smaller than a number

## Text

Write a function to find the previous palindrome of a specified number.

## Code

```csharp
public int PreviousPalindrome(int num) {
    for (int x = num - 1; x > 0; x--) {
        if (x.ToString() == new string(x.ToString().Reverse().ToArray())) {
            return x;
        }
    }
    return 0; // In case no palindrome is found, though it shouldn't be needed based on problem constraints.
}
```

## Test List

```csharp
Debug.Assert(PreviousPalindrome(99) == 88);
```

```csharp
Debug.Assert(PreviousPalindrome(1221) == 1111);
```

```csharp
Debug.Assert(PreviousPalindrome(120) == 111);
```
