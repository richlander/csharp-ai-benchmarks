# mbcp-485 -- Find the largest palindromic number in an array

## Text

Write a function to find the largest palindromic number in the given array.

## Code

```csharp
bool IsPalindrome(int n) 
{
    int divisor = 1;
    while (n / divisor >= 10) 
    {
        divisor *= 10;
    }
    while (n != 0) 
    {
        int leading = n / divisor;
        int trailing = n % 10;
        if (leading != trailing) 
        {
            return false;
        }
        n = (n % divisor) / 10;
        divisor /= 100;
    }
    return true;
}

int LargestPalindrome(int[] A, int n) 
{
    Array.Sort(A);
    for (int i = n - 1; i >= 0; i--) 
    {
        if (IsPalindrome(A[i])) 
        {
            return A[i];
        }
    }
    return -1;
}
```

## Test List

```csharp
Debug.Assert(LargestPalindrome(new int[] { 1, 232, 54545, 999991 }, 4) == 54545);
```

```csharp
Debug.Assert(LargestPalindrome(new int[] { 1, 2, 3, 4, 5, 50 }, 6) == 5);
```

```csharp
Debug.Assert(LargestPalindrome(new int[] { 1, 3, 7, 9, 45 }, 5) == 9);
```
