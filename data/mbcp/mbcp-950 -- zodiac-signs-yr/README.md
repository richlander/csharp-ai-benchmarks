# mbcp-950 -- Display Chinese zodiac sign for a given year

## Text

Write a function to display sign of the chinese zodiac for given year.

## Code

```csharp
string ChineseZodiac(int year) 
{
    string sign;
    if ((year - 2000) % 12 == 0)
    {
        sign = "Dragon";
    }
    else if ((year - 2000) % 12 == 1)
    {
        sign = "Snake";
    }
    else if ((year - 2000) % 12 == 2)
    {
        sign = "Horse";
    }
    else if ((year - 2000) % 12 == 3)
    {
        sign = "sheep";
    }
    else if ((year - 2000) % 12 == 4)
    {
        sign = "Monkey";
    }
    else if ((year - 2000) % 12 == 5)
    {
        sign = "Rooster";
    }
    else if ((year - 2000) % 12 == 6)
    {
        sign = "Dog";
    }
    else if ((year - 2000) % 12 == 7)
    {
        sign = "Pig";
    }
    else if ((year - 2000) % 12 == 8)
    {
        sign = "Rat";
    }
    else if ((year - 2000) % 12 == 9)
    {
        sign = "Ox";
    }
    else if ((year - 2000) % 12 == 10)
    {
        sign = "Tiger";
    }
    else
    {
        sign = "Hare";
    }
    return sign;
}
```

## Test List

```csharp
Debug.Assert(ChineseZodiac(1997) == "Ox");
```

```csharp
Debug.Assert(ChineseZodiac(1998) == "Tiger");
```

```csharp
Debug.Assert(ChineseZodiac(1994) == "Dog");
```
