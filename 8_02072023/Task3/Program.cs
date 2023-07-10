// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// 2 4 | 3 4 2
// 3 2 | 3 3 1
// Результирующая матрица будет:
// 18 20 8
// 15 18 7


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

bool ValidateRows1Columns2(int columnsArr1, int rowsArr2)
{
    if (rowsArr2 != columnsArr1)
    {
        Console.WriteLine("Количество столбцов первой матрицы должно совпадать с количеством строк второй матрицы");
        return false;
    }
    return true;
}

int[,] CompositionArr(int[,] arr1, int[,] arr2)
{
    int[,] array = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            array[i,j] = 0;
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                array[i,j] += arr1[i,k] * arr2[k,j];
            }
        }
    }
    return array;
}

int rows1 = Prompt("Введите число строк первой матрицы");
int columns1 = Prompt("Введите число столбцов первой матрицы");
int[,] array1 = CreateArr(rows1, columns1);
ShowArray(array1);
System.Console.WriteLine();

int rows2 = Prompt("Введите число строк второй матрицы");
int columns2 = Prompt("Введите число столбцов второй матрицы");
int[,] array2 = CreateArr(rows2, columns2);
ShowArray(array2);
System.Console.WriteLine();



if (ValidateRows1Columns2(columns1, rows2))
{
    int[,] array3 = CompositionArr(array1, array2);
    Console.WriteLine("Произведение матриц:");
    ShowArray(array3);
    
}
 
