# mbcp-407 -- Create next bigger number from digits rearrangement

## Text

Write a function to create the next bigger number by rearranging the digits of a given number.

## Code

```csharp
public int? RearrangeBigger(int n) 
{
    char[] nums = n.ToString().ToCharArray();
    for (int i = nums.Length - 2; i >= 0; i--)
    {
        if (nums[i] < nums[i + 1])
        {
            char[] z = nums.Skip(i).ToArray();
            char y = z.Where(x => x > z[0]).Min();
            List<char> zList = z.ToList();
            zList.Remove(y);
            zList.Sort();
            List<char> result = new List<char>(nums.Take(i));
            result.Add(y);
            result.AddRange(zList);
            return int.Parse(new string(result.ToArray()));
        }
    }
    return null;
}
```

## Test List

```csharp
Debug.Assert(RearrangeBigger(12) == 21);
```

```csharp
Debug.Assert(RearrangeBigger(10) == false);
```

```csharp
Debug.Assert(RearrangeBigger(102) == 120);
```
