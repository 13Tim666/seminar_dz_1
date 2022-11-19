//Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
int [] InputDigitsInArray(int length){
    int [] newArray = new int[length];
    for (int i = 0; i < newArray.Length; i++)
        { newArray[i] = Convert.ToInt32(Console.ReadLine());}
        return newArray;
}
int SiftDigits(int [] userArray){
    int positivNumbers = 0; 
    for (int i = 0; i < userArray.Length; i++){
        if (userArray[i] > 0) positivNumbers++;
    }
    return positivNumbers;
}
Console.WriteLine("Сколько чисел вы хотите ввести?");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Спасибо, вводите числа через ENTER");

Console.WriteLine("Количество чисел больше нуля " + SiftDigits(InputDigitsInArray(length)));
*/


//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*
double Equation(double k1, double b1, double k2, double b2){
    double x;
    x = (b2 - b1) / (k1 - k2);
    return x;
}

void IntersectionLines(double k1, double b1, double k2, double b2, double x){
    if ((k1*x+b1) == (k2*x+b2)){
        Console.WriteLine($"Прямые пересекаются в точке ({x} | {k2*x+b2})");
        }
}

Console.WriteLine("согласно системе уравнений, введите следующие данные:");
Console.WriteLine(" Г y = k1 * x + b1");
Console.WriteLine("<| ");
Console.WriteLine(" L y = k2 * x + b2");

Console.Write("Введите k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

if ((k1 - k2) != 0){
double equ = Equation(k1, b1, k2, b2);
IntersectionLines(k1, b1, k2, b2, equ);
}
else {Console.WriteLine("Прямые параллельны, следовательно не пересекаются");}
*/