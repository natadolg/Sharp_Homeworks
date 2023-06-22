// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Реализовать через функции.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}

int SumDigitNum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

int number = Prompt("Введите целое число ");

Console.WriteLine($"Сумма цифр числа {number} равна {SumDigitNum(number)}");