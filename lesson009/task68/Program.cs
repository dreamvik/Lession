//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
int GetArgument(string ArgumentName)
{

    int Number = -1;

    while (Number < 0)
    {
        Console.Write($"Введите натуральное число {ArgumentName} -> ");
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

int Akk(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}
 
//начало программы

int m = GetArgument("m");
int n = GetArgument("n");
int result = Akk(m, n);
Console.WriteLine($"m = {m}, n = {n} -> A({m},{n}) = {result}");