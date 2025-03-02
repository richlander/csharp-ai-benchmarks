# mbcp18 -- Remove chars in first string found in second string

## Text

Write a function to remove characters from the first string which are present in the second string.

## Code

```csharp
const int NO_OF_CHARS = 256;

public List<char> StrToList(string str)
{
    List<char> temp = new List<char>();
    foreach (char x in str)
    {
        temp.Add(x);
    }
    return temp;
}

public string LstToString(List<char> list)
{
    return new string(list.ToArray());
}

public int[] GetCharCountArray(string str)
{
    int[] count = new int[NO_OF_CHARS];
    foreach (char i in str)
    {
        count[i]++;
    }
    return count;
}

public string RemoveDirtyChars(string str, string secondStr)
{
    int[] count = GetCharCountArray(secondStr);
    int ipInd = 0;
    int resInd = 0;
    char temp;
    List<char> strList = StrToList(str);
    while (ipInd != strList.Count)
    {
        temp = strList[ipInd];
        if (count[temp] == 0)
        {
            strList[resInd] = strList[ipInd];
            resInd++;
        }
        ipInd++;
    }
    return LstToString(strList.GetRange(0, resInd));
}
```

## Test List

```csharp
Debug.Assert(RemoveDirtyChars("probasscurve", "pros") == "bacuve");
```

```csharp
Debug.Assert(RemoveDirtyChars("digitalindia", "talent") == "digiidi");
```

```csharp
Debug.Assert(RemoveDirtyChars("exoticmiles", "toxic") == "emles");
```
