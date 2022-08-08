int[] array ={1,34,5,46,52,51,54,34};//Масив
//Lengih подщитывает элемент массива
int n = array.Length;
int find = 4;//Можно использовать с окном ввода пользователя 
int index = 0; //сщетчик индекса 

while (index < n)//Цикл индекс меньше н
{
    if (array[index] == find)//Сравнение индекс в масиве равен финд
//то выводим на экран индекс
    {
        Console.WriteLine(index);  
    }
//  index +=1; или index = index +1;
    index++;
}