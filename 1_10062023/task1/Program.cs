//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());


if (num1 > num2)
{
   Console.WriteLine($"Наибольшее число = {num1}");
   Console.WriteLine($"Наименьшее число = {num2}");
}
if (num1 < num2)
{
    Console.WriteLine($"Наибольшее число = {num2}");
    Console.WriteLine($"Наименьшее число = {num1}");
}
if (num1 == num2)
{
    Console.WriteLine("Числа равны");
}