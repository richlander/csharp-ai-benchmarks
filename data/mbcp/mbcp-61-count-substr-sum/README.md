# mbcp61 -- Count substrings where digit sum equals length

## Text

Write a C# function to count number of substrings with the sum of digits equal to their length.

## Code

```csharp
public int CountSubstrings(string s, int n) {
    int count = 0, sum = 0;
    var mp = new Dictionary<int, int>();
    mp[0] = 1;

    for (int i = 0; i < n; i++) {
        sum += s[i] - '0';
        count += mp.TryGetValue(sum - (i + 1), out int value) ? value : 0;
        if (mp.ContainsKey(sum - (i + 1))) {
            mp[sum - (i + 1)]++;
        } else {
            mp[sum - (i + 1)] = 1;
        }
    }
    return count;
}
```

## Test List

```csharp
Debug.Assert(CountSubstrings("112112", 6) == 6);
```

```csharp
Debug.Assert(CountSubstrings("111", 3) == 6);
```

```csharp
Debug.Assert(CountSubstrings("1101112", 7) == 12);
```
