// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив: 14 72
// 59 23
// 84 24
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();

Console.WriteLine($"\n\nЗадача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");

Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m]; //создаем двухмерный массив 
FillArrayRandom(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double ava = 0; //счетчик 
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        ava = (ava + numbers[i, j]);
    }
    ava = ava / n;
    Console.Write(ava + "; ");
}
Console.WriteLine();
PrintArray(numbers);


void FillArrayRandom(int[,] array) //функция рандома 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array) //функция print 
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}