/*
Напишите программу, которая принимает не вход трехначное число и на выходе показывакет вторубю цифру этого числа.
*/
Console.WriteLine("Задание №1");
Console.WriteLine("Напишите программу, которая принимает на вход трехначное число и на выходе показывакет вторубю цифру этого числа.");

int number = Convert.ToInt32(Console.ReadLine());

string gg = Convert.ToString(number);

Console.WriteLine("Вторая цифра числа: ",+gg[1]);

/*
int[] arrey = Console.ReadLine("Введем трехзначное число ==> "());
int n = arrey.Length;
Console.WriteLine(n);
*/
/*
int numb = Convert.ToInt32(Console.ReadLine());
int[] arrey = {numb};
int gg = arrey.Length;
Console.WriteLine(gg);




int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);
*/