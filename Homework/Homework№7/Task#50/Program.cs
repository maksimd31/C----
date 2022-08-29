// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.(на вход именно поступает позиция элемента, можете разбить на две переменные или прописать в одну строку и конвертировать в два числа, комментарии в конце семинара по этой задаче)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Clear();


Console.Write("Введите Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[10, 10]; //создаем двухмерный массив 10х10


// || Операция логического сложения. Возвращает true, если хотя бы один из операндов возвращает true.
// (описание) | и || (а также & и &&) выполняют похожие действия, однако же они не равнозначны.
if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет"); // то есть по столбцу и по строке проверка в не массива!
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n - 1, m - 1]}");
}



void FillArrayRandom(int[,] array) //функция рандома 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10;
        }
    }
}

void PrintArray(int[,] array)//функция вывода на экран 
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

FillArrayRandom(numbers);
PrintArray(numbers);

/*
Convert.ToInt32() (преобразует к типу int)

Convert.ToDouble() (преобразует к типу double)

Convert.ToDecimal() (преобразует к типу decimal)
*/