//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

//Получить у пользователя число (N)
//для каждого числа от 1 до N мы будем проходить циклом и вычислять его куб
//вывести на экран результат

Console.WriteLine("Введите любое целое число");
string Number = Console.ReadLine();
int N = Convert.ToInt32(Number);
string Result = string.Empty;
string Separator = ", ";
for (int i = 1; i <= N; i++)
{
    if (i == N)
    {
        Separator = "";
    };
    int Cube = i * i * i;
    Result = Result + Cube + Separator;
}
Console.WriteLine($"{N} -> {Result}");
