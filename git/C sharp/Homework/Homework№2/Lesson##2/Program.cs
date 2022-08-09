Console.WriteLine("Задание №2");

Console.WriteLine("Напишите программу,которая выводит третью цифру заданного числа ил собщает что третьей цыфры нет. ");

int number = Convert.ToInt32(Console.ReadLine());

string gg = Convert.ToString(number);
if (gg.Length>1)
{
    Console.WriteLine("Третья цыфра числа " + gg[2]);
}
else if (gg.Length>2)
{
    Console.WriteLine("Третья цыфра числа " + gg[2]);
}
else if (gg.Length>4)
{
    Console.WriteLine("Ввод не сответсвует задаче!\nВведите трехзнвчное число! ");
}
else 
{
    Console.WriteLine("Ввод не сответсвует задаче!\nВведите трехзнвчное число! ");
}
