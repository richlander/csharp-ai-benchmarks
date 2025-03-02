# mbcp-539 -- Generate power list using map function

## Text

Write a function to create a list containing the power of said number in bases raised to the corresponding number in the index using map function.

## Code

```csharp
public List<int> BasesNumCoresspondingNum(List<int> basesNum, List<int> index)
{
    List<int> result = basesNum.Zip(index, (b, i) => (int)Math.Pow(b, i)).ToList();
    return result;
}
```

## Test List

```csharp
Debug.Assert(BasesNumCoresspondingNum(new int[] {10, 20, 30, 40, 50, 60, 70, 80, 90, 100}, new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}).SequenceEqual(new long[] {10, 400, 27000, 2560000, 312500000, 46656000000, 8235430000000, 1677721600000000, 387420489000000000, 100000000000000000000}));
```

```csharp
Debug.Assert(BasesNumCoresspondingNum(new int[]{1, 2, 3, 4, 5, 6, 7}, new int[]{10, 20, 30, 40, 50, 60, 70}) == new long[]{1, 1048576, 205891132094649, 1208925819614629174706176, 88817841970012523233890533447265625, 48873677980689257489322752273774603865660850176, 143503601609868434285603076356671071740077383739246066639249});
```

```csharp
Debug.Assert(BasesNumCoresspondingNum(new int[] { 4, 8, 12, 16, 20, 24, 28 }, new int[] { 3, 6, 9, 12, 15, 18, 21 }).SequenceEqual(new long[] { 64, 262144, 5159780352, 281474976710656, 32768000000000000000, 6979147079584381377970176, 2456510688823056210273111113728 }));
```
