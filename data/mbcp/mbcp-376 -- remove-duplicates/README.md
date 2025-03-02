# mbcp-376 -- Remove duplicates from a tuple and replace them

## Text

Write a function to remove tuple elements that occur more than once and replace the duplicates with some custom value.

## Code

```csharp
public Tuple<string> RemoveReplica(Tuple<string> testTup)
{
    HashSet<string> temp = new HashSet<string>();
    var res = testTup.Select(ele => !temp.Contains(ele) && temp.Add(ele) ? ele : "MSP").ToArray();
    return Tuple.Create(res);
}
```

## Test List

```csharp
Debug.Assert(RemoveReplica(new Tuple<int, int, int, int, int, int, int, int, int, int>(1, 1, 4, 4, 4, 5, 5, 6, 7, 7)).Equals(new Tuple<object, object, int, object, object, int, object, int, int, object>(1, "MSP", 4, "MSP", "MSP", 5, "MSP", 6, 7, "MSP")));
```

```csharp
Debug.Assert(RemoveReplica(new Tuple<int, int, int, int, int, int, int, int, int, int, int>(2, 3, 4, 4, 5, 6, 6, 7, 8, 9, 9)) == new Tuple<int, object, int, object, int, object, int, int, int, object>(2, 3, 4, "MSP", 5, 6, "MSP", 7, 8, 9, "MSP"));
```

```csharp
Debug.Assert(RemoveReplica(new Tuple<int, int, int, int, int, int, int, int, int, int>(2, 2, 5, 4, 5, 7, 5, 6, 7, 7)).Equals(new Tuple<int, string, int, int, string, int, string, int, string, string>(2, "MSP", 5, 4, "MSP", 7, "MSP", 6, "MSP", "MSP")));
```
