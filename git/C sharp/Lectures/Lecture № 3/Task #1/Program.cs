//vid
void Metod1() //Метод 
{
    Console.WriteLine("Автор ....."); // Что выполняет метод 
}
Metod1(); //Вызов метода 

//Вид 2
void Metod2(string msg)// метод/название/тип/переменная
{
    Console.WriteLine(msg); // что выполняет метод 

}
Metod2("Текс сообщения "); //Вызов Метода и присвоение аргумента

//Вариант 2 /метод вызывает текс 4 раза  
void Metod2v1(string msg1, int count )// метод/название/тип/переменная
{
    int i=0;
    while (i<count)
    {
        Console.WriteLine(msg1);
        i++;
    }

}
//Metod2v1("Текст сообщения", 4 ); //Вызов Метода и присвоение аргумента
Metod2v1(msg1: "Текст сообщения", count: 4 ); //точное указание параметров ,( можно писать в разнобой)

//Вид 3 /[Ничего не возвращает, Ничего не принимает] 

int Metod3()
{
    return DateTime.Now.Year;
}
int Year = Metod3();
Console.WriteLine(Year); 
// Показывает текущий год.

//Вид Методы что то принимают и что то возвращают
//этот метод печатает склеенный текст 10 раз 
string Metod4(int count, string text )
{
    int i=0; //счетчик 
    string result = string.Empty; // у переменной result строка и объявляем что строка пустая! 
    while (i<count)// цикл пока i меньше count цикл будет выполнятся 
    {
        result = result + text; //происходит склеивание  
        i++;
    }
    return result; // останавливаем цикл при достижении цели
}
string res = Metod4(10, "qwerty"); //Объявляем метод 
Console.WriteLine(res); //Выводим метод 

