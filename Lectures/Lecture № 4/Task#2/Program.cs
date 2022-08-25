int[,] matrix = new int[3, 4];

void PrintArray(int[,] mart)
{

    for (int i = 0; i < mart.GetLength(0); i++)
    {
        for (int j = 0; j < mart.GetLength(1); j++)
        {
            Console.Write($"{mart[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] mart)
{
    for (int i = 0; i < mart.GetLength(0); i++)
    {
        for (int j = 0; j < mart.GetLength(1); j++)
        {
            mart[i, j] = new Random().Next(1, 10);
        }
    }
}
