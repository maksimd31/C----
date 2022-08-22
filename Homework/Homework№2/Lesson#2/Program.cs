
Console.WriteLine("Задание №2");
Console.WriteLine("Напишите программу,которая выводит третью цифру заданного числа или собщает что третьей цыфры нет. ");
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

string gg = Convert.ToString(number);
//Запускаем цикл если это делать через int или str ничего не сработает, но если мы использем счетчик цифр и сравним его с количеством ед индекса.
if (gg.Length > 2)
{
    Console.WriteLine("Третья цифра числа: " + gg[2]);
}
else
{
    Console.WriteLine("Ввод не соответствует задаче!\nВведите трехзначное число!");
}

