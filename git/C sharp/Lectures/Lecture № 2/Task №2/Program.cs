/*
Функции и методы 
1. Блок с методом расчета, пишится один раз с верху
*/
int Max(int a1, int a2, int a3)
{
    int numders = a1;
    if (a2>numders) numders = a2;
    if (a3>numders) numders = a3;
    return numders;
}
/*
Обявление перемных и присваение к ним значений 
*/
int a1 = 12;
int a2 = 111;
int a3 = 333;
/*
Создаем список, в котором используем функцию Max. Функция Max прописывается с верхним ргистром 
*/
int numders = Max(a1, a2, a3);
Console.WriteLine(numders);
//С помощью метода  
