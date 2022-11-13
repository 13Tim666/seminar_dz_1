//Задача 25: Напишите программу, которая принимает на вход два 
//числа (A и B) и возводит число A в натуральную степень B (Math.Pow НЕ использовать)

/*
int Stepen(int a, int b){
    int result = a;
    for (int i = 1; i < b; i++){
        result = result * a;
    }
    return result;
}
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b > 0){
    int result = Stepen(a, b);
    Console.WriteLine($"{a}^{b}={result}");
} 
if (b == 0){
    Console.WriteLine($"{a}^{b}=1");
} 
if (b < 0) Console.WriteLine("Программа не умеет вычислять корень");
*/

//Задача 27: Напишите программу, которая принимает на вход 
//число и выдаёт сумму цифр в числе.

/*
void Sumnum(int num){
    int result = 0;
    int number = 0;
    while (num > 0)
    {
        number = num % 10;
        num = num / 10;
        result = result + number;
    }
    Console.Write(result);
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Сумма цифр в числе " + num + " = ");
Sumnum(num);
*/


//Задача 29: Напишите программу, которая создает массив
//заданного пользователем размера, заполняет массив элементами от 1 до 99 и выводит их на экран.

/*
int []Createarray(int length){
    int [] newarray = new int[length];
    for (int i = 0; i < length ; i++){
        newarray[i] = new Random().Next(1,100);
    }
return newarray;
}

void Printarray(int [] newarray){
    Console.Write("[");
    for(int i = 0; i < newarray.Length; i++){
        Console.Write($"{newarray[i]}, ");
    }
    Console.Write("\b\b]");
}

Console.Write("Введите длинну нового массива: ");
int length = Convert.ToInt32(Console.ReadLine());

Printarray(Createarray(length));
*/
