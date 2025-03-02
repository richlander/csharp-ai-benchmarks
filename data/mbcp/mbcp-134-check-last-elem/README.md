# mbcp134 -- Check last array element's parity after p operations

## Text

Write a C# function to check whether the last element of given array is even or odd after performing an operation p times.

## Code

```csharp
public string CheckLast(int[] arr, int n, int p) 
{ 
    int sum = 0; 
    for (int i = 0; i < n; i++) 
    { 
        sum += arr[i]; 
    } 
    if (p == 1) 
    { 
        if (sum % 2 == 0) 
        { 
            return "ODD"; 
        } 
        else 
        { 
            return "EVEN"; 
        } 
    } 
    return "EVEN"; 
}
```

## Test List

```csharp
Debug.Assert(CheckLast(new int[] { 5, 7, 10 }, 3, 1) == "ODD");
```

```csharp
Debug.Assert(CheckLast(new int[] { 2, 3 }, 2, 3) == "EVEN");
```

```csharp
Debug.Assert(CheckLast(new int[] { 1, 2, 3 }, 3, 1) == "ODD");
```
