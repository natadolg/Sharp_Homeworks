// Задайте значения M и N. Напишите программу, которая выведет 
//все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


Console.Clear();
int ReadInt(string message)
{
    Console.Write(message);                      
    int number = Convert.ToInt32(Console.ReadLine());   
    return number;                                      
}

void PrintNaturalEvenNumber(int numM, int numN)
{
    if (numM > numN) return ;
    if (numM % 2 == 0) Console.WriteLine(numM);
    PrintNaturalEvenNumber(numM + 1, numN);
}

int numberM = ReadInt("Введите начальное значение промежутка M =  ");
int numberN = ReadInt("Введите начальное значение промежутка N =  ");
PrintNaturalEvenNumber(numberM, numberN);