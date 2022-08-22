//тип/переменная/блок рандомайзера
//Программа производит сложение двух чисел
int numberA = new Random().Next(1, 10); //1 2 3 4 ... 9

Console.WriteLine(numberA);

int numberB = new Random().Next(1, 10);

Console.WriteLine(numberB);

int result = numberA + numberB;

Console.WriteLine(result);

/*

int numberA = 3;
int nember = 5;
int redult = numberA+nember;
Console.WriteLine(numberA+nember);
*/
