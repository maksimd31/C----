/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

Console.Clear();
Console.WriteLine("Введите первое число: ");
int numOne = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numTwo = int.Parse(Console.ReadLine());

int getRate(int numberOne, int numberTwo)
{
    int totalNum = numOne;
    for(int i = 1; i < numTwo; i++) {
        totalNum *= numOne;
    }
    return totalNum;
}

Console.WriteLine($"Результат = {getRate(numOne, numTwo)}");
//семенар 

/*
Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
  123
[5, 18, 123, 6, 2] -> 1 [1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int[] arr = new int[20]; // создали массив из восьми элементов

void RandomArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        //Создание объекта для генерации чисел
        Random rnd = new Random();
        //Получить случайное число 
        int value = rnd.Next(1000);
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}

void IsNumInArray(int[] array)
{
    int numExist = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 10 && arr[i] < 99)
        {
            numExist++;
        }
    }
    if (numExist > 0)
    {
        Console.WriteLine($"Количество чисел - {numExist}");
    }
    else
    {
        Console.WriteLine($"Чисел нет - {numExist}");
    }
}

RandomArray(arr);
IsNumInArray(arr);

/*
Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int [size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

int [] array = GetArray(5, 0, 9);
Console.WriteLine();
int pow = 0;

for(int i = 0; i <= array.Length / 2; i++)
{
    if(i != array.Length - 1 - i)
    {
    pow = array[i] * array[array.Length - 1 - i];
    }
    else
    {
        pow = array[i];
    }
    Console.WriteLine($"{pow} ");
    
}