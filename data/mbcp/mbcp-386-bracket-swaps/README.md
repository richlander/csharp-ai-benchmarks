# mbcp386 -- Minimize swaps for bracket balancing in a string

## Text

Write a function to find out the minimum no of swaps required for bracket balancing in the given string.

## Code

```csharp
public static int SwapCount(string s) {
    char[] chars = s.ToCharArray();
    int countLeft = 0;
    int countRight = 0;
    int swap = 0;
    int imbalance = 0; 
    for (int i = 0; i < chars.Length; i++) {
        if (chars[i] == '[') {
            countLeft++;
            if (imbalance > 0) {
                swap += imbalance;
                imbalance--;
            }
        } else if (chars[i] == ']') {
            countRight++;
            imbalance = (countRight - countLeft);
        }
    }
    return swap;
}
```

## Test List

```csharp
Debug.Assert(SwapCount("[]][][") == 2);
```

```csharp
Debug.Assert(SwapCount("[[][]]") == 0);
```

```csharp
Debug.Assert(SwapCount("[[][]]][") == 1);
```
