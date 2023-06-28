// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.
//  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений у = {lineData1[COEFFICIENT]} * x + {lineData1[CONSTANT]} и y = {lineData2[COEFFICIENT]} * x + {lineData2[CONSTANT]}");
    Console.WriteLine($" имеет координаты ({coord[X_COORD]:f2}, {coord[Y_COORD]:f2})");
}

//Ввод числа
double Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

//ввод данных по прямой
double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[COEFFICIENT] = Prompt($"Введите коэффициент для {numberOfLine} прямой >");
    lineData[CONSTANT] = Prompt($"Введите коэффициент для {numberOfLine} прямой >");
    return lineData;    
}

//Поиск координат
double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X_COORD] = (lineData1[COEFFICIENT] - lineData2[COEFFICIENT]) /(lineData2[CONSTANT] - lineData1[CONSTANT]);
    coord[Y_COORD] = lineData1[CONSTANT] * coord[X_COORD] + lineData1[COEFFICIENT];
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineDate2)
{
    if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
    {
        if (lineData1[CONSTANT] == lineData2[CONSTANT])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}

