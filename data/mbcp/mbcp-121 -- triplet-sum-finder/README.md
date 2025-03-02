# mbcp-121 -- Find triplet in array with a specific sum

## Text

Write a function to find the triplet with sum of the given array

## Code

```csharp
bool CheckTriplet(int[] A, int n, int sum, int count) {
    if (count == 3 && sum == 0) {
        return true;
    }
    if (count == 3 || n == 0 || sum < 0) {
        return false;
    }
    return CheckTriplet(A, n - 1, sum - A[n - 1], count + 1) || 
           CheckTriplet(A, n - 1, sum, count);
}
```

## Test List

```csharp
Debug.Assert(CheckTriplet(new int[] { 2, 7, 4, 0, 9, 5, 1, 3 }, 8, 6, 0) == true);
```

```csharp
Debug.Assert(CheckTriplet(new int[] { 1, 4, 5, 6, 7, 8, 5, 9 }, 8, 6, 0) == false);
```

```csharp
Debug.Assert(CheckTriplet(new int[] {10, 4, 2, 3, 5}, 5, 15, 0) == true);
```
