
//двухмерные массивы  
// string[,] tab =new string[10, 10]; //таблица строк

// table[0,0] table[0,1]//столбы 
// table[1,0] table[1,1]//столбы 
//tab[1,2] = "test"; //прямоугольная таблица чисел [строки/столбцы]

// GetLength(0)//количество строк  

// string[,] tab =new string[10, 10]; //таблица строк
string[,] table = new string[2, 5];
// String.Empty
// table [0,0] table [0,1] table [0,2] table [0,4]
// table [1,0] table [1,1] table [1,2] table [1,4]
table[1, 2] = "слово";

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);//[1; 10)
        }
    }
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

// void FillArray (int[,]tab)
// {
//     for(int i=0; i < tab.GetLength(0); i++) //столбы
//     {
//         for(int j=0; j < tab.GetLength(1); j++) //строки 
//         {
//         tab[i,j] = "" + Convert.ToInt32(new Random().Next(1,10)); //блок рандома 
//         }
//     Console.WriteLine();
//     }
// }

// //Вывод на экран
// void PrintArray(int[,]tab)//метод 
// {
//     for(int i=0; i < tab.GetLength(0); i++) //цикл столбы 
//     {
//         for(int j=0; j < tab.GetLength(1); j++) //цикл строки 
//         {
//             Console.Write($" {tab[i,j]} "); //вывод на экран 
//         }
//     Console.WriteLine();
//     }
// }
// /*
// Двухмерные массивы/ тип данных[,] наименование = обязательное условие new тип данных [строки/столбцы]
// int[,] matrix = new int[3,4];
// */
// int[,] matrix = new int[3,4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);