int[,] cost1 = { { 1, 2, 3 }, { 4, 8, 2 }, { 1, 5, 3 } };
int m1 = 2, n1 = 2;
int result1 = MinCost(cost1, m1, n1);
Console.WriteLine($"Minimum cost to reach (2, 2) = {result1} (Expected: 8, Correct: {result1 == 8})");

int[,] cost2 = { { 2, 3, 4 }, { 5, 9, 3 }, { 2, 6, 4 } };
int m2 = 2, n2 = 2;
int result2 = MinCost(cost2, m2, n2);
Console.WriteLine($"Minimum cost to reach (2, 2) = {result2} (Expected: 12, Correct: {result2 == 12})");

int[,] cost3 = { { 3, 4, 5 }, { 6, 10, 4 }, { 3, 7, 5 } };
int m3 = 2, n3 = 2;
int result3 = MinCost(cost3, m3, n3);
Console.WriteLine($"Minimum cost to reach (2, 2) = {result3} (Expected: 16, Correct: {result3 == 16})");

static int MinCost(int[,] cost, int m, int n)
{
    int R = cost.GetLength(0);
    int C = cost.GetLength(1);
    int[,] tc = new int[R, C];

    tc[0, 0] = cost[0, 0];

    for (int i = 1; i <= m; i++)
        tc[i, 0] = tc[i - 1, 0] + cost[i, 0];

    for (int j = 1; j <= n; j++)
        tc[0, j] = tc[0, j - 1] + cost[0, j];

    for (int i = 1; i <= m; i++)
    {
        for (int j = 1; j <= n; j++)
        {
            tc[i, j] = Math.Min(tc[i - 1, j - 1], Math.Min(tc[i - 1, j], tc[i, j - 1])) + cost[i, j];
        }
    }

    return tc[m, n];
}
