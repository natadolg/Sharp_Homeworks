// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет. Не использовать строки.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ReadInt(string message)
{
    Console.Write(message);                      // Вывод приглашения
    int number = Convert.ToInt32(Console.ReadLine());   // Чтение строки и преобразование в число
    return number;                                      // Возврат целого числа
}

bool Validate2sign(int number)
{
    if (number < 100)
    {
        Console.WriteLine("В числе нет третьей цифры");
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


int digit = ReadInt("Введите число: ");
int thirdigit;

if (Validate2sign(digit))
{
    thirdigit = Revers(digit) % 1000 / 100;
    Console.WriteLine($"{thirdigit}");
}


