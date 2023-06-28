// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 6] -> 0


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

int SumEvenPosition(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}
Console.Clear();
int len = Prompt("Введите длину массива ");
int startArr = Prompt("Введите начальное значение диапазона элементов массива ");
int endArr = Prompt("Введите конечное значение диапазона элементов массива ");

int[] arr = GenerateArray(len, startArr, endArr);
PrintArray(arr);
System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в массиве равна {SumEvenPosition(arr)}");

