# mbcp-317 -- Reflect run-length encoding in a list function

## Text

Write a function to reflect the modified run-length encoding from a list.

## Code

```csharp
using System.Collections.Generic;
using System.Linq;

public class Encoder
{
    public List<object> ModifiedEncode(List<int> alist)
    {
        List<object> result = new List<object>();
        
        var grouped = alist.GroupBy(x => x);
        foreach (var group in grouped)
        {
            result.Add(CtrEle(group.ToList()));
        }
        
        return result;
    }

    private object CtrEle(List<int> el)
    {
        if (el.Count > 1) 
            return new object[] { el.Count, el[0] };
        else 
            return el[0];
    }
}
```

## Test List

```csharp
Debug.Assert(ModifiedEncode(new List<int> { 1, 1, 2, 3, 4, 4, 5, 1 }).SequenceEqual(new List<object> { new List<int> { 2, 1 }, 2, 3, new List<int> { 2, 4 }, 5, 1 }));
```

```csharp
Debug.Assert(ModifiedEncode("automatically").SequenceEqual(new object[] { 'a', 'u', 't', 'o', 'm', 'a', 't', 'i', 'c', 'a', new object[] { 2, 'l' }, 'y' }));
```

```csharp
Debug.Assert(ModifiedEncode("python").SequenceEqual(new char[] { 'p', 'y', 't', 'h', 'o', 'n' }));
```
