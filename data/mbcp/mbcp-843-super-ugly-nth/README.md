# mbcp843 -- Find the nth super ugly number using a heap

## Text

Write a function to find the nth super ugly number from a given prime list of size k using heap queue algorithm.

## Code

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int NthSuperUglyNumber(int n, int[] primes)
    {
        List<int> uglies = new List<int> { 1 };
        
        IEnumerable<IEnumerable<long>> Generate(int prime)
        {
            foreach (long ugly in uglies)
            {
                yield return new long[] { ugly * prime };
            }
        }

        IEnumerable<long> merged = primes.SelectMany(p => Generate(p)).OrderBy(x => x).Distinct();

        using (var enumerator = merged.GetEnumerator())
        {
            while (uglies.Count < n)
            {
                enumerator.MoveNext();
                long ugly = enumerator.Current;
                if (ugly != uglies.Last())
                {
                    uglies.Add((int)ugly);
                }
            }
        }
        
        return uglies.Last();
    }
}
```

## Test List

```csharp
Debug.Assert(NthSuperUglyNumber(12, new int[]{2, 7, 13, 19}) == 32);
```

```csharp
Debug.Assert(NthSuperUglyNumber(10, new int[] { 2, 7, 13, 19 }) == 26);
```

```csharp
Debug.Assert(NthSuperUglyNumber(100, new int[] { 2, 7, 13, 19 }) == 5408);
```
