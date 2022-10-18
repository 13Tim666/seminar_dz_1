//-----------Задача 10: Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа.
/*
int FindSecondDigit(int num)
{
    int digit = num % 100 / 10;
    return digit;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = FindSecondDigit(number);
Console.WriteLine($"Вторая цифра числа {number} является {digit}");
*/
//----------Задача 13: Напишите программу, которая выводит третью цифру
//заданного числа или сообщает, что третьей цифры нет.
/*
int FindThierdDigit(int num)
{
    while(num>999)
    {
        num = num / 10;
    }
    int digit = num % 10;
    return digit;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>99)
{
    int digit = FindThierdDigit(number);
    Console.WriteLine("третья цифра числа " +number+ " является " + digit);
}
else Console.WriteLine("третьей цифры нет");
*/

//------------Задача 15: Напишите программу, которая принимает
//на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool weekday(int num)
{
    if (num>5) return true;
    else return false;
}

Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>0 & number<8)
{
    bool day = weekday(number);
    if (day) Console.Write("День недели: " + number + " Выходной");
    else Console.Write("День недели: " + number + " Рабочий");
}
else Console.Write("День недели: " + number + " несуществует");
*/