// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
int[,] CreateArr(int rows, int cols)
{
    int[,] arrayD2 = new int[rows, cols];
    for (int i = 0; i < arrayD2.GetLength(0); i++)
    {
        for (int j = 0; j < arrayD2.GetLength(1); j++)       
        {
            arrayD2[i,j] = new Random().Next(0, 11);
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

void AverageColumnsArr(int[,] arr)
{
    System.Console.WriteLine("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
       double sum = 0;
       for (int i = 0; i < arr.GetLength(0); i++)
       {
            sum += arr[i,j];
       }
       {
            System.Console.Write($"{sum/arr.GetLength(0):f2}\t");
       } 
    }
}

int rows = Prompt("Введите число строк");
int columns = Prompt("Введите число столбцов");
int[,] array = CreateArr(rows, columns);
ShowArray(array);
System.Console.WriteLine();
AverageColumnsArr(array);