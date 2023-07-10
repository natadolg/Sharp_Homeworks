// Задайте двумерный массив. Напишите программу, 
// которая упорядочивает по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.Clear();
int[,] CreateArr(int rows, int cols) // создание двумерного массива случайных чисел
{
    int[,] arrayD2 = new int[rows, cols];
    for (int i = 0; i < arrayD2.GetLength(0); i++)
    {
        for (int j = 0; j < arrayD2.GetLength(1); j++)       
        {
            arrayD2[i,j] = new Random().Next(0, 100);
        }        
    }
    return arrayD2;
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

int[,] SelectionSortRowsArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1)-1; j++)
        {
            int maxPositionj = j;
            for (int k = j+1; k < arr.GetLength(1); k++)
            {
                if (arr[i,k] > arr[i, maxPositionj])
                {
                    maxPositionj = k;
                }
            }
            int temp = arr[i,j];
            arr[i,j] = arr[i,maxPositionj];
            arr[i,maxPositionj] = temp;
        }
    }
    return arr;
}


int rows = Prompt("Введите число строк");
int columns = Prompt("Введите число столбцов");
int[,] array = CreateArr(rows, columns);
ShowArray(array);
System.Console.WriteLine();
int[,] arrSort = SelectionSortRowsArr(array);
ShowArray(arrSort);