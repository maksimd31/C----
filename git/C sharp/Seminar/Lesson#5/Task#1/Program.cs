﻿/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/
int[] GetArray(int size, int minValue, int maxValue)//Создаем метод/аргументы/(размер/минимальное число/ максимальное число)
{
    int[] result = new int[size]; // создаем массив size и кладем в него в переменную result 
    for (int i = 0; i < result.Length; i++) //Пробегаемся по методу (Используем Length для прохода всего массива)
    {
        result[i] = new Random().Next(minValue, maxValue + 1); //в массив result кладем в i кладем рандомные числа от минимальных до максимальных +1 (Не понял почему +1)
        Console.Write($"{result[i]} "); //выводим на экран массив 
    }
    return result; //Возвращаем result 
}

int[] array = GetArray(12, -9, 9); //вызываем метод приписываем аргументы(размер массива,минимальное число,максимальное число)
int positiveSum = 0; // выводим Счетчик для записи значений 
int negativeSum = 0;
//новый цикл 
foreach (int i in array) // Для каждого элемента (i) в (array)
{
    if (i > 0) //сравниваем если i>0 то цифра положительная 
        positiveSum += i; // При нахождения положительного числа(происходит их сложение)
    else
        negativeSum += i;//аналогично первому
}
Console.WriteLine($"Сумма положительных = {positiveSum}, а сумма отрицительных = {negativeSum}" );