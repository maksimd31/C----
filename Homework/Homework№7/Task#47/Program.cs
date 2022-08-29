// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();



//Если матрица 6 строк и 8 столбцов то array.GetLength(0) вернёт 6 а array.GetLength(1) вернёт 8
void FillArrayRandom(double[,] array) //функция рандомайзера 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array) //функция вывода на экран 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");//закрываем скобки по линии n
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " "); //выставляем пробелы 
        }
        Console.Write("]"); //закрываем скобки по линии n
        Console.WriteLine("");//переводим на новую строчку по количеству n 
    }
}

Console.WriteLine($"Задача 47:\nЗадайте двумерный массив размером m x n, заполненный случайными вещественными числами.");

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[m, n];//Создаем двухмерный массив
FillArrayRandom(numbers);
PrintArray(numbers);
