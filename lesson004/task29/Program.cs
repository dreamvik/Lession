//Задача 29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

int[] CreateArray()
{
    int[] Array = new int[8];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(1, 100);
    }
    return Array;
}

void PrintArray(int[] Array)
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
    Console.WriteLine(Result);
}

int[] Array = CreateArray();

PrintArray(Array);
