# mbcp288 -- Count elements with modular inverse equal to self

## Text

Write a function to count array elements having modular inverse under given prime number p equal to itself.

## Code

```csharp
int ModularInverse(int[] arr, int N, int P) {
    int currentElement = 0;
    for (int i = 0; i < N; i++) {
        if ((arr[i] * arr[i]) % P == 1) {
            currentElement++;
        }
    }
    return currentElement;
}
```

## Test List

```csharp
Debug.Assert(ModularInverse(new int[] { 1, 6, 4, 5 }, 4, 7) == 2);
```

```csharp
Debug.Assert(ModularInverse(new int[] { 1, 3, 8, 12, 12 }, 5, 13) == 3);
```

```csharp
Debug.Assert(ModularInverse(new int[] { 2, 3, 4, 5 }, 4, 6) == 1);
```
