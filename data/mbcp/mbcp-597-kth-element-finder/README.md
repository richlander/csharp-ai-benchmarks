# mbcp597 -- Find kth element in two sorted arrays

## Text

Write a function to find kth element from the given two sorted arrays.

## Code

```csharp
public int FindKth(int[] arr1, int[] arr2, int m, int n, int k) {
    int[] sorted1 = new int[m + n];
    int i = 0, j = 0, d = 0;
    
    while (i < m && j < n) {
        if (arr1[i] < arr2[j]) {
            sorted1[d] = arr1[i];
            i++;
        } else {
            sorted1[d] = arr2[j];
            j++;
        }
        d++;
    }
    
    while (i < m) {
        sorted1[d] = arr1[i];
        d++;
        i++;
    }
    
    while (j < n) {
        sorted1[d] = arr2[j];
        d++;
        j++;
    }
    
    return sorted1[k - 1];
}
```

## Test List

```csharp
Debug.Assert(FindKth(new int[] { 2, 3, 6, 7, 9 }, new int[] { 1, 4, 8, 10 }, 5, 4, 5) == 6);
```

```csharp
Debug.Assert(FindKth(new int[] { 100, 112, 256, 349, 770 }, new int[] { 72, 86, 113, 119, 265, 445, 892 }, 5, 7, 7) == 256);
```

```csharp
Debug.Assert(FindKth(new int[] { 3, 4, 7, 8, 10 }, new int[] { 2, 5, 9, 11 }, 5, 4, 6) == 8);
```
