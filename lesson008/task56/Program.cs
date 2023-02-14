//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//функция, возвращающая двумерный массив
int[,] GetTable()
{
    int[,] Table = new int[3, 5];
    for (int row = 0; row < Table.GetLength(0); row++)
    {
        for (int col = 0; col < Table.GetLength(1); col++)
        {
            int Number = new Random().Next(1, 10);
            Table[row, col] = Number;
        }
    }
    return Table;
}

//функция, отрисовывающая таблицу в консоли
void PrintTable(int[,] Table)
{
    for (int row = 0; row < Table.GetLength(0); row++)
    {
        int Sum = 0;
        for (int col = 0; col < Table.GetLength(1); col++)
        {
            Sum = Sum + Table[row, col];
            Console.Write($"{Table[row, col]}|");
        }

        Console.WriteLine($" = {Sum}");
    }

}

//функция, возвращающая массив, элементы которого являются суммами элементов строк исходного двумерного массива
int[] GetRowSums(int[,] Table)
{
    int[] Sums = new int[Table.GetLength(0)];
    for (int row = 0; row < Table.GetLength(0); row++)
    {
        int Sum = 0;

        for (int col = 0; col < Table.GetLength(1); col++)
        {
            Sum = Sum + Table[row, col];
        }
        Sums[row] = Sum;
    }
    return Sums;
}

//функция, возвращающая номер строки с минимальной сумммой
int GetRowNumber(int[] SumsArray)
{
    int RowNumber = 0;
    for (int i = 1; i < SumsArray.Length; i++)
    {
        if (SumsArray[i] < SumsArray[i - 1])
        {
            RowNumber = i;
        }
    }
    return RowNumber + 1;
}

//начало программы

int[,] Table = GetTable();
PrintTable(Table);
int[] RowSums = GetRowSums(Table);
int RowNumber = GetRowNumber(RowSums);
Console.WriteLine($"номер строки с минимальной суммой -> {RowNumber}");
