//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

//Запросить у пользователя любое количество чисел через запятую (будет строка)
//Эту строку переделать в массив
//Пробежав по массиву, посчитать количество чисел больше нуля

int[] GetArrayFromString(string NumberStr)
{
    string[] ArrayString = NumberStr.Split(new char[] { ',' });
    int[] ArrayNumber = new int[ArrayString.Length];
    for (int i = 0; i < ArrayString.Length; i++)
    {
        int Number = Convert.ToInt32(ArrayString[i]);
        ArrayNumber[i] = Number;
    }
    return ArrayNumber;
}

int GetCount(int[] Array)
{
    int count = 0;

    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Введите отрицительные и положительные числа через запятую");
string NumberStr = Console.ReadLine();

int[] ArrayNumber = GetArrayFromString(NumberStr);
int count = GetCount(ArrayNumber);


Console.WriteLine($"{NumberStr} -> {count}");