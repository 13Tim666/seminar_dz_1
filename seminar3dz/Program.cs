//Задача 19.Напишите программу, которая принимает 
//на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool polindrom(int num)
{
    bool digit = num/10000 == num%10 & num%10000/1000 == num%100/10;
    if (digit) return true;
    else return false;
}

Console.Write("Введите 5-ти значное число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>9999 & number<99999)
{
    bool poli = polindrom(number);
    if (poli) Console.WriteLine($"Число {number} полиндром");
    else Console.WriteLine($"Число {number} не полиндром");
} 
else Console.WriteLine("Ошибка! Число должно быть 5-ти значным")
*/

//Задача 21. Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance(int xa, int xb, int ya, int yb, int za, int zb){
    double ab = Math.Sqrt(((xb-xa)*(xb-xa)) + ((yb-ya)*(yb-ya)) + ((zb-za)*(zb-za)));
    return ab;
}
Console.Write("Введите координату xa: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату xb: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату ya: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату yb: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату za: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату zb: ");
int zb = Convert.ToInt32(Console.ReadLine());

Console.Write($"Расстояние между точками ({xa},{ya},{za}) и ({xb},{yb},{zb}) равно {Distance(xa, xb, ya, yb, za, zb)}");
*/

//Задача 23. Напишите программу, которая принимает на вход число
// (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cub(int num){
    for(int i = 1; i <= num; i++){
        Console.Write($"{i*i*i} ");
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Таблица кубов от 1 до {number} выглядит так:");
Cub(number);
