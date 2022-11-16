//Задача 34: Задайте массив заполненный случайными положительными трёхзначными
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int []Createarray(int length){
    int [] newarray = new int[length];
    for (int i = 0; i < length; i++){
        newarray[i] = new Random().Next(100, 1000);
    }
    return newarray;
}
void Printarray(int [] newarray){
        Console.Write("[ ");
    for(int i = 0; i < newarray.Length; i++){
            Console.Write($"{newarray[i]}, ");
    }
        Console.WriteLine("\b\b ]");
}
void Chet(int [] newarray){
    int kol = 0;
    for(int i = 0; i < newarray.Length; i++){
        if (newarray[i] % 2 == 0) {
            kol = kol + 1;
        }
    }
    Console.Write(kol);
}
Console.Write("Введите длинну нового массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int [] newarray = Createarray(length);
Printarray(newarray);
Console.Write("Количество четных чисел: " );
Chet(newarray);
*/


//Задача 36: Задайте массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

/*
int []Createarray(int length){
    int [] newarray = new int[length];
    for (int i = 0; i < length; i++){
        newarray[i] = new Random().Next(0, 10);
    }
    return newarray;
}
void Printarray(int [] newarray){
        Console.Write("[ ");
    for(int i = 0; i < newarray.Length; i++){
            Console.Write($"{newarray[i]}, ");
    }
        Console.WriteLine("\b\b ]");
}
void Sumne(int [] newarray){
    int summa = 0;
    for (int i = 1; i < newarray.Length; i = i + 2){
        summa = summa + newarray[i];
    }
    Console.Write(summa);
}

Console.Write("Введите длинну нового массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int [] newarray = Createarray(length);
Printarray(newarray);
Console.Write("сумма элементов на нечетных позициях: " );
Sumne(newarray);
*/


//Задача 38: Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементов массива.

/*
double []Createarray(int length){
    double [] newarray = new double[length];
    for (int i = 0; i < length; i++){
        newarray[i] = new Random().Next(0, 10) + Math.Round(new Random().NextDouble(), 2);
    }
    return newarray;
}
void Printarray(double [] newarray){
        Console.Write("[ ");
    for(int i = 0; i < newarray.Length; i++){
            Console.Write($"{newarray[i]}  ");
    }
        Console.WriteLine("\b\b ]");
}

double Findmin(double [] newarray){
    double min = newarray[0];
    for (int i = 1; i < newarray.Length; i++){
        if (min > newarray[i]){
            min = newarray[i]; 
        }
    }
    return min;
}

double Findmax(double [] newarray){
    double max = newarray[0];
    for (int i = 1; i < newarray.Length; i++){
        if (max < newarray[i]){
            max = newarray[i];  
        }
    }
    return max;
}


Console.Write("Введите длинну нового массива: ");
int length = Convert.ToInt32(Console.ReadLine());

double [] newarray = Createarray(length);
Printarray(newarray);

Console.Write("Разница между максимальным и минимальным значением массива составляет: " + (Findmax(newarray) - Findmin(newarray)));
*/