int[] array ={1,34,5,46,52,4,51,54,18};//Масив
//Lengih подщитывает элемент массива
int n = array.Length;
Console.WriteLine(n);
int find = 54;//Можно использовать с окном ввода пользователя 
int index = 0; //сщетчик индекса 

while (index < n)//Цикл индекс меньше н
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++; //Не срабатывает 
    //  index +=1; или index = index +1;
}
/*
С исполтьзованием задвоением 
int[] arry ={1,34,5,46,56,56,56,34};
int n = arry.Lengih;
int find = 18;
int index = 0;

while(index<n)
{
    if (arry[index] == find)
    {
        Console.WriteLine(index);
        break;//прирываем цикл при нахождение первого значение индекса   
    }
    index++;
}
*/
