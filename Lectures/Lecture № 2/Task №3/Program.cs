/*В данном варианте принимаются 3 аргумента 
и функция страбатывает только при 3 элементах
*/
int Max(int a1, int a2, int a3)
{
    int numbers = a1;
    if (a2>numbers) numbers = a2;
    if (a3>numbers) numbers = a3;
    return numbers;
}

//тип данны/имя/значения
//. индек       0.  1.  2.  3 //{Скобки индекса}
int[] array = {11, 22, 33, 333, 43534, 445, 4554, 5422, 2332};
//array[0] = 12;
Console.WriteLine(array[0]);
//Вывод 12
//Воспользуемся первой функиией 

int max = Max(
//  Вызов функицц   аргумент1  Аргумент2  Аргумент3
    Max(array[0],array[1], array[2]),
    Max(array[3],array[4], array[5]),
    Max(array[6],array[7], array[8])
);
//покажет нам максимальное чмсло через индекс
Console.WriteLine(max);
