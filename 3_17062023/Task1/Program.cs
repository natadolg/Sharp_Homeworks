//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}

bool Validate2sign(int number)
{
    if (number < 10000 || number >= 100000)
    {
        Console.WriteLine("Введено не пятизначное число");
        return false;
    }

    return true;
}

int Revers(int number)
{
    int revNumber = 0;
    int rem;
    while (number > 0)
    {
            rem = number % 10;
            revNumber = revNumber * 10 + rem;
            number /= 10;
    }
    
    return revNumber;
}

int digit = Prompt("Введите пятизначное число ");

if (Validate2sign(digit))
{
    if (digit == Revers(digit))
    {
        Console.WriteLine($"Число {digit} - палиндром");
    }
    else
    {
        Console.WriteLine($"Число {digit} - не палиндром");
    }
}
