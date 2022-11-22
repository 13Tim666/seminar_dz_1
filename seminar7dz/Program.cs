//Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

/*
double [,] CreateDoubleArray(int line, int column){
    double [,] newArray = new double[line, column];
    for (int i = 0; i < line; i++){
        for(int j = 0; j < column; j++){
            newArray[i, j] = Math.Round((new Random().Next(-9, 10) + new Random().NextDouble()), 1);
        }
    }
    return newArray;
}

void PrintArray(double [,] newArray){
    for (int i = 0; i < newArray.GetLength(0); i++){
        for(int j = 0; j < newArray.GetLength(1); j++){
            Console.Write($"{newArray[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int line = 3; 
int column = 4;

PrintArray(CreateDoubleArray(line, column));
*/





//Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.

/*
int [,] CreateArray(int line, int column){
    int [,] newArray = new int[line, column];
    for (int i = 0; i < line; i++){
        for(int j = 0; j < column; j++){
            newArray[i, j] = new Random().Next(1, 10);
        }
    }
    return newArray;
}

void PrintArray(int [,] newArray){
    for (int i = 0; i < newArray.GetLength(0); i++){
        for(int j = 0; j < newArray.GetLength(1); j++){
            Console.Write($"{newArray[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void FindByIndex(int indexLine, int line, int indexColumn, int column, int [,] newArray){
    if (indexLine <=  line & indexColumn <= column){
        Console.Write($"Your number: {newArray[indexLine-1, indexColumn-1]}");
    }
    else Console.Write("There is no number with this index");
}

Console.Write("Input numbers of lines: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of Columns: ");
int column = Convert.ToInt32(Console.ReadLine());

int [,] newArray = CreateArray(line, column);
PrintArray(newArray);
Console.Write("Input the line index of the number: ");
int indexLine = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the column index of the number: ");
int indexColumn = Convert.ToInt32(Console.ReadLine());

FindByIndex(indexLine, line, indexColumn, column, newArray);

*/

//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

/*
int [,] CreateArray(int line, int column){
    int [,] newArray = new int[line, column];
    for (int i = 0; i < line; i++){
        for(int j = 0; j < column; j++){
            newArray[i, j] = new Random().Next(1, 10);
        }
    }
    return newArray;
}

void PrintArray(int [,] newArray){
    for (int i = 0; i < newArray.GetLength(0); i++){
        for(int j = 0; j < newArray.GetLength(1); j++){
            Console.Write($"{newArray[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void Average(int [,] newArray){
    double sumColumn;
    double averageColumn;
    for (int i = 0; i < newArray.GetLength(1); i++){
        sumColumn = 0;
        for(int j = 0; j < newArray.GetLength(0); j++){
            sumColumn = newArray[j, i] + sumColumn;}
        averageColumn = sumColumn/newArray.GetLength(0);
        Console.Write($"{Math.Round(averageColumn, 2)}  ");
    }
}

int line = 3; 
int column = 4;

int [,] newArray = CreateArray(line, column);
PrintArray(newArray);
Console.WriteLine("средние арифметические столбцов");
Average(newArray);
*/