// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int len, int min, int max) //генерируем массив случайных чисел
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array) // метод вывода массива на экран
{
    foreach (int item in array)
    {
        System.Console.Write(item + "\t");
    }
    System.Console.WriteLine();
}

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}

int CountEvenNumber(int[] arr)
{
    int count = 0;
    foreach (int item in arr)
    {
        if (item % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}

int len = Prompt("Введите длину массива ");

int[] arr = GenerateArray(len, 100, 1000);
PrintArray(arr);
System.Console.WriteLine($"Количество четных элементов массива равно {CountEvenNumber(arr)}");
