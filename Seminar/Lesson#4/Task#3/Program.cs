int[] arr = new int[8]; // создали массив из восьми элементов

void RandomArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        //Создание объекта для генерации чисел
        Random rnd = new Random();
        //Получить случайное число (в диапазоне от 0 до 10)
        int value = rnd.Next(0, 2);
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}

RandomArray(arr);