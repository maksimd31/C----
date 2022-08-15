/*
Упорядочить массив 
*/
int[] arr = {7, 5, 3, 4, 5, 6, 7, 7, 7};//массив 
//метод вывода на экран массива
void PrintArray (int[] array) //Метод/название/(тип[массив]/название 
{
    int count = array.Length;//в count записываются значение подсчета строки
    for (int i = 0; i < count; i++)//цикл прокручивания всего массива/ и записывает его в i 
    {
        Console.WriteLine($"{array[i]} "); //выводим на экран массив 
    }
    Console.WriteLine();
}
//метод растравление массива 
void SelectionSort(int[] array)
{

    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) 
            minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);


SelectionSort(arr);