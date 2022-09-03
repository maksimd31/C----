# Урок 8. Как не нужно писать код. Часть 2


# Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
## Например, задан массив:
* 1 4 7 2
* 5 9 2 3
* 8 4 2 4
#### В итоге получается вот такой массив:
* 7 4 2 1
* 9 5 3 2
* 8 4 4 2

#### Решение 
```

Console.Clear();
Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.\nВведите размер массива m x n и диапазон случайных значений: ");

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите диапазон: от 1 до => ");
int range = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n]; //Массив 
CreateArray(array);
WriteArray(array);

Console.WriteLine($"\nОтсортированный массив: "); //Сортировка 
OrderArrayL(array);
WriteArray(array);

void OrderArrayL(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}


void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
```
---
# Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
## Например, задан массив:
* 1 4 7 2
* 5 9 2 3
* 8 4 2 4
* 5 2 6 7

#### Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

#### Решение 
```
Console.Clear();

Console.WriteLine($"Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.\nВведите размер массива m x n и диапазон случайных значений:");

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите диапазон: от 1 до => ");
int range = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
CArray(array);
WArray(array);

int minSumLine = 0;
int sumLin = SumElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = SumElements(array, i);
    if (sumLin > tempSumLine)
    {
        sumLin = tempSumLine;
        minSumLine = i;
    }
}

Console.WriteLine($"\n{minSumLine + 1} - строка с наименьшей суммой ({sumLin}) элементов ");


int SumElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}


void CArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

```
---
# Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:*
* 2 4 | 3 4
* 3 2 | 3 3

*Результирующая матрица будет:*

* 18 20
* 15 18

#### Решение
```
Console.Clear();

Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.\n\nСразу зададим матрицу, которую можно перемножить, т.е. количество столбцов первой равно количеству строк второй\nВведите размеры матриц и диапазон случайных значений:");

Console.Write("Введите число строк 1-й матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов 2-й матрицы: ");
int p = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите диапазон чисел : от 1 до => ");
int range = Convert.ToInt32(Console.ReadLine());

//Первая матрица 
int[,] oneMartrix = new int[m, n];
CreateArray(oneMartrix);
Console.WriteLine($"\nПервая матрица:");
WriteArray(oneMartrix);

//Вторя матрица 
int[,] twoMartrix = new int[n, p];
CreateArray(twoMartrix);
Console.WriteLine($"\nВторая матрица:");
WriteArray(twoMartrix);
//результат 
int[,] resultMatrix = new int[m, p];

MlyMatrix(oneMartrix, twoMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);

void MlyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}


void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

```
---

# Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

## Массив размером 2 x 2 x 2
* 66(0,0,0) 25(0,1,0)
* 34(1,0,0) 41(1,1,0)
* 27(0,0,1) 90(0,1,1)
* 26(1,0,1) 55(1,1,1)

#### Решение
```
Console.Clear();

Console.WriteLine($"Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.\nВведите размер массива X x Y x Z: ");

Console.Write("Введите число X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число Y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число Z: ");
int z = Convert.ToInt32(Console.ReadLine());


int[,,] array3D = new int[x, y, z]; //массив

CrArray(array3D);
WriteArray(array3D);


void WriteArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.Write($"X({i}) Y({j}) ");
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"Z({k})={array3D[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void CrArray(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}


```
---
# Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. ( - необязательная)
## Например, на выходе получается вот такой массив:
* 01 02 03 04
* 12 13 14 05
* 11 16 15 06
* 10 09 08 07

#### Решение
```
// Задача 62(). Напишите программу, которая заполнит спирально массив 4 на 4. (необязательная)
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.Clear();

Console.WriteLine("Задача 62: Заполните спирально массив 4 на 4.");

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
    sqareMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

WriteArray(sqareMatrix);

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
```