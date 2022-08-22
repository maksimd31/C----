/*
Функции и методы 
1. Блок с методом расчета, пишится один раз с верху
*/
int Max(int a1, int a2, int a3)
{
    int numbers = a1;
    if (a2>numbers) numbers = a2;
    if (a3>numbers) numbers = a3;
    return numbers;
}
/*
Обявление перемных и присваение к ним значений 
*/
int a1 = 122;
int a2 = 2;
int a3 = 323;
int a4 = 4;
int a5 = 55;
int a6 = 6;
int a7 = 7;
int a8 = 84;
int a9 = 9;
/*
Создаем список, в котором используем функцию Max. Функция Max прописывается с верхним ргистром 
Важно 3 списка создаем тольо потому что указали 3 арнумента!
*/
int max1 = Max(a1, a2, a3);
int max2 = Max(a4, a5, a6);
int max3 = Max(a7, a8, a9);
int max = Max(max1, max2, max3);

Console.WriteLine(max);
//С помощью метода
/*
//или
int max = Max(
    Max(a1,a2,a3),
    Max(a4,a5,a6),
    Max(a7,a8,a9)); 

*/
