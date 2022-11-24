//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

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

int [,] SortMaxMin(int [,] newArray){
    int temp;
    for (int i = 0; i < newArray.GetLength(0); i++){
        for(int j = 0; j < newArray.GetLength(1)-1; j++){{
                if (newArray[i, j] < newArray[i, j + 1]) {
                    temp = newArray[i, j];
                    newArray[i, j] = newArray[i, j+1];
                    newArray[i, j+1] = temp;
                    }
                }
        }
    }
    return newArray;
}

int line = 3; 
int column = 4;

int [,] newArray = CreateArray(line, column);
PrintArray(newArray);
Console.WriteLine("Sorted array_________________");
SortMaxMin(newArray);
PrintArray(newArray);
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите 
//программу, которая будет находить строку с наименьшей суммой элементов.

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

void MinimalSum(int [,] newArray){
    int sumLine = 0;
    int minSum = 0;
    int minSumLineIndex = 0;
    for (int i = 0; i < newArray.GetLength(0); i++){
        for(int j = 0; j < newArray.GetLength(1); j++){
            sumLine = sumLine + newArray[i, j];
            }
        if (i == 0) minSum = sumLine;
        if (minSum > sumLine){
                minSum = sumLine;
                minSumLineIndex = i;
        }
        sumLine = 0;
    }
    Console.WriteLine(minSumLineIndex);
}

int line = 5; 
int column = 4;

int [,] newArray = CreateArray(line, column);
PrintArray(newArray);
Console.Write("minimum summa line index: ");
MinimalSum(newArray);

*/


//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

/*
int [,] CreateArray(int line, int column){
    int [,] newArray = new int [line, column];
    int i = 0;
    int j = 0;
    int digit = 0;
    int count = line%2 + line/2;
    int beginColumn = 0;
    int endColumn = column;
    int beginLine = 0;
    int endLine = line;
    for (int x = 0; x < count; count++) {

        while (j<endColumn) {
            digit++;
            newArray[i, j] = digit;
            j++;
        } 
        j--;
     
        while (i<endLine-1) {
            digit++;
            newArray[i+1, j] = digit;
            i++;
        }
    if (newArray[i,j-1] != 0) break;
        while (j>beginColumn) {
            digit++;
            newArray[i, j-1] = digit;
            j--;
        }
    if (newArray[i-1,j] != 0) break;
        while (i>beginLine+1) {
            digit++;
            newArray[i-1, j] = digit;
            i--;
        } 
    j++;
    endColumn--;
    endLine--;
    beginColumn++;
    beginLine++;
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

Console.Write("Input numbers of lines: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of Columns: ");
int column = Convert.ToInt32(Console.ReadLine());

PrintArray(CreateArray(line, column));

*/

//Задача 58:(дополнительно) Задайте две матрицы. Напишите 
//программу, которая будет находить произведение двух матриц

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


int [,] Multiplication(int [,]firstArray, int [,]secondArray){
        int[,] newArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
        for (int i = 0; i < firstArray.GetLength(0); i++){
            for (int j = 0; j < secondArray.GetLength(1); j++){
                for (int k = 0; k < secondArray.GetLength(0); k++){
                newArray[i,j] += firstArray[i,k] * secondArray[k,j];
            }
        }
    }
    return newArray;
}

Console.Write("Input numbers of lines for first array: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of Columns for first array: ");
int column = Convert.ToInt32(Console.ReadLine());

int [,] firstArray = CreateArray(line,column);
PrintArray(firstArray);

Console.Write("Input numbers of lines for second array: ");
line = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of Columns for second array: ");
column = Convert.ToInt32(Console.ReadLine());

int [,] secondArray = CreateArray(line,column);
PrintArray(secondArray);

if (firstArray.GetLength(1) != secondArray.GetLength(0)) Console.WriteLine("array cannot be multiplied");
Console.WriteLine("result multiplied:");

PrintArray(Multiplication(firstArray, secondArray));

*/

//Задача 60.(дополнительно) ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*
int [,,] CreateArray(int line, int column, int depth, int [] numbersArray){
    int [,,] newArray = new int[line, column, depth];
    int x;
    for (int i = 0; i < line; i++){
        for(int j = 0; j < column; j++){
            for(int k = 0; k < depth; k++){
                x = new Random().Next(0,90);
                if (numbersArray[x]!=0){
                    newArray[i, j, k] = numbersArray[x];
                    numbersArray[x] = 0;
                }
                else k--;
            }
        }
    }
    return newArray;
}

void PrintArray(int [,,] newArray){
    for (int i = 0; i < newArray.GetLength(0); i++){
        for(int j = 0; j < newArray.GetLength(1); j++){
            for(int k = 0; k < newArray.GetLength(2); k++){
                Console.Write($"{newArray[i, j, k]}({i},{j},{k})  ");
            }
        Console.WriteLine();
        }   
        Console.WriteLine();
    }
}

int [] numbersArray = new int[90];
for(int i = 0; i < 90; i++){
    numbersArray[i] = i+10;
}


Console.Write("Input numbers of lines: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of Columns: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of depth: ");
int depth = Convert.ToInt32(Console.ReadLine());


PrintArray(CreateArray(line, column, depth, numbersArray));

*/