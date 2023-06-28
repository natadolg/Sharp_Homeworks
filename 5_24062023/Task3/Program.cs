// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7.4, 22.3, 2, 78] -> 76

double[] GenerateArray(int len, int min, int max) //генерируем массив случайных чисел
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
    }
    return array;
}

void PrintArray(double[] array) // метод вывода массива на экран
{
    foreach (double item in array)
    {
        System.Console.Write("{0:0.00} ", item );
    }
    System.Console.WriteLine();
}

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}

double MaxNumberArray(double[] array)
{
    double maxNum = array[0];
    foreach (double item in array)
    {
        if (item > maxNum)
        {
            maxNum = item;
        }
    }
    return maxNum;
}
double MinNumberArray(double[] array)
{
    double minNum = array[0];
    foreach (double item in array)
    {
        if (item < minNum)
        {
            minNum = item;
        }
    }
    return minNum;
}

Console.Clear();
int len = Prompt("Введите длину массива ");
int startArr = Prompt("Введите начальное значение диапазона элементов массива ");
int endArr = Prompt("Введите конечное значение диапазона элементов массива ");


double[] arr = GenerateArray(len, startArr, endArr);
PrintArray(arr);
System.Console.WriteLine($"Максимальный элемент массива равен {MaxNumberArray(arr):f2}");
System.Console.WriteLine($"Минимальный элемент массива равен {MinNumberArray(arr):f2}");
System.Console.WriteLine($"разница между максимальным и минимальным элементами массива равна {(Math.Abs(MaxNumberArray(arr)) - Math.Abs(MinNumberArray(arr))):f2}");