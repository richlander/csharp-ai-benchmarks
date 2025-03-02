# mbcp-100 -- Find the next smallest palindrome number

## Text

Write a function to find the next smallest palindrome of a specified number.

## Code

```csharp
public static long NextSmallestPalindrome(long num)
{
    for (long i = num + 1; i < long.MaxValue; i++)
    {
        if (i.ToString() == new string(i.ToString().Reverse().ToArray()))
        {
            return i;
        }
    }
    return -1; // In case no palindrome is found within the range
}
```

## Test List

```csharp
Debug.Assert(NextSmallestPalindrome(99) == 101);
```

```csharp
Debug.Assert(NextSmallestPalindrome(1221) == 1331);
```

```csharp
Debug.Assert(NextSmallestPalindrome(120) == 121);
```
