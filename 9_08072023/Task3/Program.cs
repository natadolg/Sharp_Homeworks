// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29


Console.Clear();
int ReadInt(string message)
{
    Console.Write(message);                      
    int number = Convert.ToInt32(Console.ReadLine());   
    return number;                                      
}

int FnAkkerman(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    else if (numM > 0 && numN == 0) return FnAkkerman(numM - 1, 1);
    else return FnAkkerman(numM - 1, FnAkkerman(numM, numN - 1));
}

int numberM = ReadInt("Введите неотрицательное число M =  ");
int numberN = ReadInt("Введите неотрицательное число N =  ");
Console.WriteLine(FnAkkerman(numberM, numberN));