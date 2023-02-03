// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] GetArray()
{
    int Length = 7;
    int[] Array = new int[Length];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = GetNumber();
    }
    return Array;
}

//функция, которая возвращает случайное число

int GetNumber()
{
    Random random = new Random();

    int Number = random.Next(-100, 100);

    return Number;
}

//фуенкция, которая возвращает строку из полученного массива

string ArrayToString(int[] Array)
{
    string Result = "[";
    string Separator = ", ";

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

//функция, определяющая, является ли число нечетным

bool IsOdd(int Number)
{
    int Rest = Number % 2;
    return Rest != 0;
}
//функция, считающая сумму элементов, стоящих на нечетных позициях

int GetSum(int[] Array)
{
    int Sum = 0;
    for (int i = 1; i <= Array.Length; i++)
    {
        if (IsOdd(i))
        {
            Sum = Sum + Array[i - 1];
        }
    }

    return Sum;
}


int[] Array = GetArray();

int Sum = GetSum(Array);

string ArrayStr = ArrayToString(Array);

Console.WriteLine($"{ArrayStr} -> {Sum}");