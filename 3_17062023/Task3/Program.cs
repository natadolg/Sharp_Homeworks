// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}

int number = Prompt("Введите число N");

for (int i = 1; i <= number; i++)
{
    System.Console.WriteLine( Math.Pow(i,3));
}