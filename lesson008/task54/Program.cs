// Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

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
        for (int col = 0; col < Table.GetLength(1); col++)
        {
            Console.Write($"{Table[row, col]}|");
        }
        Console.WriteLine();
    }

}

//функция, упорядывающая элементы таблицы
int[,] SortTable(int[,] Table)
{
    for (int row = 0; row < Table.GetLength(0); row++)
    {
        for (int col = 0; col < Table.GetLength(1); col++)
        {
            for (int j = 0; j < Table.GetLength(1) - 1 - col; j++)
            {
                if (Table[row, j] > Table[row, j + 1])
                {
                    int Temp = Table[row, j];
                    Table[row, j] = Table[row, j + 1];
                    Table[row, j + 1] = Temp;
                }
            }

        }
    }
    return Table;
}

//функция, упорядывающая элементы таблицы по убыванию
int[,] ReversTable(int[,] Table)
{
    for (int row = 0; row < Table.GetLength(0); row++)
    {
        for (int firstCol = 0, lastCol = Table.GetLength(1) - 1; firstCol < lastCol; firstCol++, lastCol--)
        {
            int Temp = Table[row, firstCol];
            Table[row, firstCol] = Table[row, lastCol];
            Table[row, lastCol] = Temp;
        }
    }
    return Table;
}

//начало программы

int[,] Table = GetTable();
Console.WriteLine("неотсортированная таблица");
PrintTable(Table);
int[,] SortedTable = SortTable(Table);
int[,] ReversedTable = ReversTable(SortedTable);

Console.WriteLine("");
Console.WriteLine("отсортированная по убыванию таблица");
PrintTable(ReversedTable);