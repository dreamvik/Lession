//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
//функция, запрашивающая значение начала или конца интервала у пользователя и возвращающая его в интовом значении
//если значение нельзя привести к типу Int, то возвращается -1


int GetIntervalValue(string Name)
{

    int Number = -1;

    while (Number < 0)
    {
        Console.Write($"Введите натуральное число {Name} -> ");
        string ValueStr = Console.ReadLine();
        if (int.TryParse(ValueStr, out int NumericValue))
        {
            Number = Convert.ToInt32(ValueStr);
            if (Number < 0)
            {
                Console.WriteLine("это не натуральное число!");
            }
        }
        else
        {
            Console.WriteLine("это не натуральное число!");
        };
    }


    return Number;
}

int GetIntervalSum(int Start, int End)
{
    if (Start == End)
    {
        return Start;
    }
    return Start + GetIntervalSum(Start + 1, End);

}

//начало программы

int M = GetIntervalValue("M");
int N = GetIntervalValue("N");

int StartInterval = M;
int EndInterval = N;

if (StartInterval > EndInterval)
{
    StartInterval = N;
    EndInterval = M;
}
int Sum = GetIntervalSum(StartInterval, EndInterval);
Console.WriteLine($"Суммой чисел интервала [{StartInterval}, {EndInterval}] будет {Sum}");