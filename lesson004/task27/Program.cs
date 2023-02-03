//Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int SumNumber(int numberN)
{
    int advance = 0;
    int result = 0;
    while (numberN > 0)
    {
        advance = numberN % 10;
        result = result + (advance);
        numberN = numberN / 10;
    }
    return result;
}
int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);