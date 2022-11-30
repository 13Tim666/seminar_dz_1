//Задача 64: Задайте значение N. Напишите программу, которая выведет
//все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*
void maxMin(int n){
    if (n == 1){
        Console.Write($"{n}");
    }
    else {
        Console.Write($"{n}, ");
        n--;
        maxMin(n);
    }
}

Console.Write("Enter digit: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Natural numbers from {n} to 1 : "); 
maxMin(n);

*/


//Задача 66: Задайте значения M и N. Напишите программу,
//которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int SumNumbers(int m, int n){
    if (n == m) return m;
    return (n + SumNumbers(m, n - 1));
}


Console.Write("Enter number FROM: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number TO: ");
int n = Convert.ToInt32(Console.ReadLine());

int resultSumNumbers = SumNumbers(m, n);
Console.WriteLine(resultSumNumbers);
*/


//Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackerman(int m, int n){
if (m == 0) return n + 1;
if ((m > 0) && (n == 0)) return Ackerman(m - 1, 1);
if ((m > 0) && (n > 0)) return Ackerman(m - 1, Ackerman(m, n - 1));
else return 0;
}

Console.WriteLine(Ackerman(3, 2));

