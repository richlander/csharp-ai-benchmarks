# mbcp-552 -- Check if a sequence is linear using Python

## Text

Write a C# function to check whether a given sequence is linear or not.

## Code

```csharp
public string SeqLinear(List<int> seqNums) 
{
    for (int x = 1; x < seqNums.Count; x++) 
    {
        seqNums[x] = seqNums[x] - seqNums[x - 1];
    }
    
    if (seqNums.Distinct().Count() == 1) 
    {
        return "Linear Sequence";
    }
    else 
    {
        return "Non Linear Sequence";
    }
}
```

## Test List

```csharp
Debug.Assert(SeqLinear(new int[] { 0, 2, 4, 6, 8, 10 }) == "Linear Sequence");
```

```csharp
Debug.Assert(SeqLinear(new int[] { 1, 2, 3 }) == "Linear Sequence");
```

```csharp
Debug.Assert(SeqLinear(new int[] { 1, 5, 2 }) == "Non Linear Sequence");
```
