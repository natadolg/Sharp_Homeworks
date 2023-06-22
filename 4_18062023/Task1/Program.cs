// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// Реализовать через функции.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}

int DegreeNumber(int A, int B)
{
    int degreeNumber = 1;
    for (int i = 1; i <= B; i++)
    {
        degreeNumber *= A;
    } 
    return degreeNumber; 
}

bool ValidateB(int number)
{
    if (number < 0)
    {
        Console.WriteLine("Введена отрицательная степень. Задачу решить не могу.");
        return false;
    }
    return true;
}

int numberA = Prompt("Введите число A");
int numberB = Prompt("Введите число B");

if (ValidateB(numberB))
{
    Console.WriteLine($"Число {numberA} в степени {numberB} равно {DegreeNumber(numberA,numberB)}");
}



