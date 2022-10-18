//---------------Задача 2: Напишите программу, которая на вход принимает 
//два числа и выдаёт, какое число большее, а какое меньшее.

/*Console.WriteLine("Введите два числа");
Console.Write("введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1>num2)
{
    Console.WriteLine($"Число {num1} больше чем число {num2}");
}
if (num1<num2)
{
    Console.WriteLine($"Число {num1} меньше чем число {num2}");
}
if (num1==num2)
{
    Console.WriteLine("Числа равны");   
}
*/
//-----------Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*Console.WriteLine("Введите три числа");
Console.Write("введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());


int max = num1;
if (max<num2)
{
    max = num2; 
}
if (max<num3)
{
    max = num3;
}
Console.WriteLine("Максимальное число " + max);
*/
//-----------Задача 6: Напишите программу, которая на вход
//принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*Console.Write("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num % 2) == 0)
{
    Console.Write("число " + num + " четное");
}
else
{
    Console.Write("число " + num + " нечетное");
}
*/
//----------Задача 8: Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.
/*Console.Write("введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 0;
int count = num1 / 2;
if (count <= 0)
{
    Console.WriteLine("число должно быть больше 1");
}
else
{
    Console.Write("четные числа от 1 до " + num1 + ": ");
}
while (count > 0)
{
    num2 = num2 + 2;
    Console.Write(num2 + " ");
    count--;
}
*/
