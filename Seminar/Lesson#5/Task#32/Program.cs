/*
Задание № 32
Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 

*/

int[] GetArray(int size, int minValue, int maxValue) // метод массив/аргумент(размер/мин/макс)
{
    int[] result = new int[size]; //создаем массив result и кладем в него в переменную size 
    for (int i = 0; i < result.Length; i++)// цикл пробегаемся по массиву 
    {
        result[i] = new Random().Next(minValue, maxValue + 1); //в массив result кладем в i кладем рандомные числа от минимальных до максимальных +1 (метод Next включает первое число не не включает второе)
        Console.Write($"{result[i]} "); //выводим массив на экран
    }
    return result; //возвращаем значение 
}
int[] ReverseArray(int[] array) // 
{   int [] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
        Console.Write($"{array[i]} ");
    }
    return newArray;
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine();
ReverseArray(array);