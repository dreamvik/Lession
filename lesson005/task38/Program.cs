// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] GetArray()
{
    int Length = 7;
    double[] Array = new double[Length];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = GetNumber();
    }
    return Array;
}

//функция, которая возвращает случайное вещественное число

double GetNumber()
{
    Random random = new Random();

    double Number = random.NextDouble() * (100 - 10) + 10;
    double RoundNumber = Math.Round(Number, 2);
    return RoundNumber;

}

//функция, которая возвращает строку из полученного массива

string ArrayToString(double[] Array)
{
    string Result = "[";
    string Separator = " ";

    for (int i = 0; i < Array.Length; i++)
    {
        if (i == Array.Length - 1)
        {
            Separator = "]";
        }
        Result = Result + Array[i] + Separator;
    }
    return Result;
}

//функция, определяющая разницу между максимальным и минимальным элементами массива

double GetDiffFromArray(double[] Array)
{
    double? Diff = null;
    double? Max = null;
    double? Min = null;


    for (int i = 0; i < Array.Length; i++)
    {
        if (Min is null)
        {
            Min = Array[i];

        }

        if (Max is null)
        {
            Max = Array[i];
        }

        if (Array[i] < Min) { Min = Array[i]; }
        if (Array[i] > Max) { Max = Array[i]; }

    }
    Diff = Max - Min;

    return Math.Round((double) Diff, 2);
}


double[] Array = GetArray();

double Diff = GetDiffFromArray(Array);

string ArrayStr = ArrayToString(Array);

Console.WriteLine($"{ArrayStr} -> {Diff}");
