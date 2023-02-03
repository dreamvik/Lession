// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да
int[] GetNumberArray(int Number)
{
    int[] Array = new int[5];
    int First = Number / 10000;
    int Second = (Number - First * 10000) / 1000;
    int Third = (Number - First * 10000 - Second * 1000) / 100;
    int Fourth = (Number - First * 10000 - Second * 1000 - Third * 100) / 10;
    int Fifth = Number - First * 10000 - Second * 1000 - Third * 100 - Fourth * 10;
    Array[0] = First;
    Array[1] = Second;
    Array[2] = Third;
    Array[3] = Fourth;
    Array[4] = Fifth;
    return Array;

};
//Получить у пользователя пятизначное число
Console.WriteLine("Введите пятизначное число");
int Number = Convert.ToInt32(Console.ReadLine());
//Сравнить первую и пятую цифру числа
//Сравнить вторую и четвертую цифру числа
//выведем палиндром или нет
int[] Array = GetNumberArray(Number);
string IsPalindrom = "нет, это число не палиндром";
if (Array[0] == Array[4] && Array[1] == Array[3])
{
    IsPalindrom = "да, это число палиндром";
}
Console.WriteLine($"{Number} -> {IsPalindrom}");
