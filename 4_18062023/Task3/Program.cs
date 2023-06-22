// Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
// Оформите заполнение массива и вывод в виде функции
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 -> 8

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}

bool ValidateAB(int numberA, int numberB)
{
    if (numberB < numberA)
    {
        Console.WriteLine("Начальное значение диапазона случайных чисел дожно быть меньше конечного числа");
        return false;
    }
    return true;
}
int[] GetRandomArray(int lenght, int initValue, int finalValue)
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(initValue,finalValue);
    }
    return array;
}

void ShowArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write($"{item} ");
    }
}

int lenght = Prompt("Введите длину массива ");
int number1 = Prompt("Введите начальное значение диапазона случайных чисел");
int number2 = Prompt("Введите конечное значение диапазона случайных чисел");

if (ValidateAB(number1, number2))
{
    ShowArray(GetRandomArray(lenght, number1, number2));
}