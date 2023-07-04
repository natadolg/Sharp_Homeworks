// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет
// 2, 1 -> 4


Console.Clear();
int[,] CreateArr(int rows, int cols)
{
    int[,] arrayD2 = new int[rows, cols];
    for (int i = 0; i < arrayD2.GetLength(0); i++)
    {
        for (int j = 0; j < arrayD2.GetLength(1); j++)       
        {
            arrayD2[i,j] = new Random().Next(0, 255);
        }        
    }
    return arrayD2;
}

void ShowArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)       
        {
            System.Console.Write($"{array[i,j]}\t");
        }        
        System.Console.WriteLine();
    } 
}

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}

bool ValidateRows(int rows, int cols, int[,] arr)
{
    if (rows > arr.GetLength(0) || cols >  arr.GetLength(1))
    {
        Console.WriteLine("Такого числа в массиве нет");
        return false;
    }
    return true;
}

int rows = Prompt("Введите число строк");
int columns = Prompt("Введите число столбцов");
int[,] array = CreateArr(rows, columns);
ShowArray(array);
System.Console.WriteLine();
int numRows = Prompt("Введите номер строки");
int numColumns = Prompt("Введите номер строки");
if (ValidateRows(numRows, numColumns, array))
{
    System.Console.WriteLine($"{array[numRows, numColumns]}");
}