
//Определили масив из 10 элементов 
int[] array = new int[10];
//Метод (тип данных/аргумент)
//Генерирует случайные числа/зполняет массив
void FillArraay(int[] colle)
{
    int length = colle.Length;//определяет длину массива
    int index = 0;
    while (index<length)
    {
        array[index]= new Random().Next(1,10);
        index++;
    }
}
//распечатывает 
void PrintArry(int[] colleprint)
{
    int count = colleprint.Length;
    int position = 0;
    while(position<count)
    {
        Console.WriteLine(colleprint[position]);
        position++;
    }
}
//меотод off
int IndexOf(int[] colle, int find)
{
    int count = colle.Length;
    int index = 0;
    int position = -1;//убираем 1 элемент/-1 это значит элемент не найден!
    while(index<count)
    {
        if(colle[index]== find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
//тестируем масив
FillArraay(array);
PrintArry(array);
int pos = IndexOf(array, 4);//ищем 4 меняется значение(Можно прикруть ввод с клавы)
Console.WriteLine(pos);

/*


}
int IndexOf(int[] colle, int find)
{ 
    int count = colle.Length;
    int index = 0; 
    int position = -1;//убираем элемен/-1 элемент не найден!
    while (index<count)
    {
        if(colle[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
}    retern position;
int[] array = new int[10];// Масив 
//тестируем масив
FillArraay(arry);
PrintArry(arry);

Console.WriteLine();
int pos = IndexOf(arry, 4); //ищем 4 меняется значение 
Console.WriteLine(pos);
*/