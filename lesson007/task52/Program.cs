// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
        for (int col = 0; col < Table.GetLength(1); col++)
        {
            Console.Write($"{Table[row, col]}|");
        }
        Console.WriteLine();
    }

}
//функция, которая вернет нам среднее арифметическое столбцов

string GetColumnsAverage(int[,] Table)
{
    string ColumnsAverage = String.Empty;
    for (int ColumnIndex = 0; ColumnIndex < Table.GetLength(1); ColumnIndex++)
    {
        double Average = 0;
        double Sum = 0;
        for (int RowIndex = 0; RowIndex < Table.GetLength(0); RowIndex++)
        {
            Sum = Sum + Table[RowIndex, ColumnIndex];
        }
        Average = Math.Round(Sum / Table.GetLength(0), 2);
        ColumnsAverage = ColumnsAverage + Average + "| ";
    }
    return ColumnsAverage;
}

//начало программы

int[,] Table = GetTable();
PrintTable(Table);
string Average = GetColumnsAverage(Table);
Console.WriteLine($"Среднее арифметическое столбцов -> {Average}");
