// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int[,] CreateArr(int rows, int cols) // создание двумерного массива случайных чисел
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)       
        {
            array[i,j] = new Random().Next(0, 10);
        }        
    }
    return array;
}

void ShowArray(int[,] array) //вывод на экран двумерного массива
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

int Prompt(string message) // считывание числа (количества строк и столбцов)
{
    System.Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}

int SumLineArr(int[,] arr, int line)
{
    int  SumLine = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        SumLine += arr[line,j];
    }
    return SumLine;
}

int MinSumLine(int[,] arr)
{
    int sumMin = SumLineArr(arr, 0);
    int lineMin = 1;
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        if (SumLineArr(arr, i) < sumMin)
        {
            sumMin = SumLineArr(arr, i);
            lineMin = i + 1;

        }
    
    }
   return lineMin;
}

int rows = Prompt("Введите число строк");
int columns = Prompt("Введите число столбцов");
int[,] array = CreateArr(rows, columns);
ShowArray(array);
System.Console.WriteLine();

System.Console.Write($"Номер строки с наименьшей суммой элементов: {MinSumLine(array)} строка");

