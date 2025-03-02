# mbcp-689 -- Minimum jumps to reach array's end

## Text

## write a function to find the minimum number of jumps to reach the end of the array for the given array of integers where each element represents the max number of steps that can be made forward from that element. > indented block > indented block

## Code

```csharp
public static int MinJumps(int[] arr, int n) {
    int[] jumps = new int[n];
    if (n == 0 || arr[0] == 0) {
        return int.MaxValue;
    }
    jumps[0] = 0;
    for (int i = 1; i < n; i++) {
        jumps[i] = int.MaxValue;
        for (int j = 0; j < i; j++) {
            if (i <= j + arr[j] && jumps[j] != int.MaxValue) {
                jumps[i] = Math.Min(jumps[i], jumps[j] + 1);
                break;
            }
        }
    }
    return jumps[n - 1];
}
```

## Test List

```csharp
Debug.Assert(MinJumps(new int[] { 1, 3, 6, 1, 0, 9 }, 6) == 3);
```

```csharp
Debug.Assert(MinJumps(new int[] { 1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9 }, 11) == 3);
```

```csharp
Debug.Assert(MinJumps(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 11) == 10);
```
