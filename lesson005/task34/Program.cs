//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int GetNumber()
{
    Random random = new Random();

    int Number = random.Next(100, 999);

    return Number;
}

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

int GetEvenCount(int[] Array)
{
    int Count = 0;

    for (int i = 0; i < Array.Length; i++)
    {
        int Rest = Array[i] % 2;

        bool IsEven = Rest == 0;

        if (IsEven)
        {
            Count++;
        }
    }

    return Count;

}

int[] Array = GetArray();

int CountEven = GetEvenCount(Array);

string ArrayStr = ArrayToString(Array);

Console.WriteLine($"{ArrayStr} -> {CountEven}");
