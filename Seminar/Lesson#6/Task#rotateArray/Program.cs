//Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

//Метод рандома 
int[] GetArray(int size, int minValue, int maxValue)//Аргументы 
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
        Console.Write($"{res[i]} ");
    }
    return res;
}
//Создание массива 
int[] ReverseArray(int[] inArray)//Метод создания массива
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i]; // длину - 1 - i (запись с конца)
        Console.Write($"{result[i]} ");
    }
    return result; //вернем 
}

int[] array = GetArray(8, 1, 9);
Console.WriteLine();
Console.WriteLine(String.Join("", array));
ReverseArray(array);