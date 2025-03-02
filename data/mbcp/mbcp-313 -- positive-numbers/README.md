# mbcp-313 -- Prints positive numbers from a given list

## Text

Write a C# function to print positive numbers in a list.

## Code

```csharp
public int PosNos(List<int> list1) {
    foreach (int num in list1) {
        if (num >= 0) {
            return num;
        }
    }
    return default; // or throw an exception if no positive number is found
}
```

## Test List

```csharp
Debug.Assert(PosNos(new int[] { -1, -2, 1, 2 }) == new int[] { 1, 2 });
```

```csharp
Debug.Assert(PosNos(new int[] { 3, 4, -5 }) == (3, 4));
```

```csharp
Debug.Assert(PosNos(new int[] { -2, -3, 1 }) == 1);
```
