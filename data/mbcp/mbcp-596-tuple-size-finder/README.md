# mbcp596 -- Find the size of a given tuple

## Text

Write a function to find the size of the given tuple.

## Code

```csharp
using System;

public class TupleSizeCalculator
{
    public static long TupleSize(object tupleList)
    {
        return System.Runtime.InteropServices.Marshal.SizeOf(tupleList);
    }
}
```

## Test List

```csharp
Debug.Assert(TupleSize(("A", 1, "B", 2, "C", 3)) == System.Runtime.InteropServices.Marshal.SizeOf(typeof(ValueTuple<string, int, string, int, string, int>)));
```

```csharp
Debug.Assert(TupleSize((1, "Raju", 2, "Nikhil", 3, "Deepanshu")) == System.Runtime.InteropServices.Marshal.SizeOf<(int, string, int, string, int, string)>((1, "Raju", 2, "Nikhil", 3, "Deepanshu")));
```

```csharp
Debug.Assert(TupleSize(((1, "Lion"), (2, "Tiger"), (3, "Fox"), (4, "Wolf"))) == System.Runtime.InteropServices.Marshal.SizeOf(((1, "Lion"), (2, "Tiger"), (3, "Fox"), (4, "Wolf"))));
```
