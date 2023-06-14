// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
int ReadInt(string message)
{
    Console.Write(message);                      // Вывод приглашения
    int number = Convert.ToInt32(Console.ReadLine());   // Чтение строки и преобразование в число
    return number;                                      // Возврат целого числа
}

bool notDayWeek(int number)
{
    if (number < 1 || number > 7)
    {
        Console.WriteLine("В неделе только 7 дней!");
        return false;
    }

    return true;
}

string DayOff(int number)
{
    string answ = "Рабочий день. Отдыхать рано!";
    if (number == 6 || number == 7)
    {
        answ = "Ура! Выходной!";
        
    }
    return answ;
}

int digit = ReadInt("Введите номер дня недели: ");

if (notDayWeek(digit))
{
    Console.WriteLine($"{DayOff(digit)}");
}