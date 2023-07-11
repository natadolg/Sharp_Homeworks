// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30


Console.Clear();
int ReadInt(string message)
{
    Console.Write(message);                      
    int number = Convert.ToInt32(Console.ReadLine());   
    return number;                                      
}

int SumNaturalNumberMN(int numM, int numN)
{
    if (numM > numN) return 1;
    return  numM * SumNaturalNumberMN(numM + 1, numN);
}

int numberM = ReadInt("Введите начальное значение промежутка M =  ");
int numberN = ReadInt("Введите начальное значение промежутка N =  ");
Console.WriteLine(SumNaturalNumberMN(numberM, numberN));