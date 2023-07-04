// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
double[,] CreateArr(int rows, int cols)
{
    double[,] arrayD2 = new double[rows, cols];
    Random rnd = new Random();
    for (int i = 0; i < arrayD2.GetLength(0); i++)
    {
        for (int j = 0; j < arrayD2.GetLength(1); j++)       
        {
            arrayD2[i,j] = rnd.NextDouble() * (10);
        }        
    }
    return arrayD2;
}

void ShowArray(double[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)       
        {
            System.Console.Write($"{array[i,j]:f2}\t");
        }        
        System.Console.WriteLine();
    } 
}

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}

int rows = Prompt("Введите число строк");
int columns = Prompt("Введите число столбцов");
ShowArray(CreateArr(rows, columns));