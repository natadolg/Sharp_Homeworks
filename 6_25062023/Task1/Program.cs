// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


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

int Count0Number(int[] arr)
{
    int count = 0;
    foreach (int item in arr)
    {
        if (item > 0)
        {
            count += 1;
        }
    }
    return count;
}

Console.Clear();
int len = Prompt("Введите длину массива ");
int startArr = Prompt("Введите начальное значение диапазона элементов массива ");
int endArr = Prompt("Введите конечное значение диапазона элементов массива ");

int[] arr = GenerateArray(len, startArr, endArr);
PrintArray(arr);
System.Console.WriteLine($"Количество чисел больших нуля равно {Count0Number(arr)}");