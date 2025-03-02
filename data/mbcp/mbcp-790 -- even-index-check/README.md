# mbcp-790 -- Check if even indices have even numbers

## Text

Write a C# function to check whether every even index contains even numbers of a given list.

## Code

```csharp
public bool EvenPosition(int[] nums)
{
    return nums.Select((num, i) => num % 2 == i % 2).All(x => x);
}
```

## Test List

```csharp
Debug.Assert(EvenPosition(new int[] { 3, 2, 1 }) == false);
```

```csharp
Debug.Assert(EvenPosition(new int[] { 1, 2, 3 }) == false);
```

```csharp
Debug.Assert(EvenPosition(new int[] { 2, 1, 4 }) == true);
```
