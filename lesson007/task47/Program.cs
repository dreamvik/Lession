//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.

//0,5 7 -2 -0,2

//1 -3,3 8 -9,9

//8 7,8 -7,1 9

double[,] GetTable()
{
    double[,] Table = new double[3, 4];
    for (int row = 0; row < Table.GetLength(0); row++)
    {
        for (int col = 0; col < Table.GetLength(1); col++)
        {
            double Number = new Random().NextDouble() * (100 + 100) - 100;
            Table[row, col] = Math.Round(Number, 2);
        }
    }
    return Table;
}

//функция, отрисовывающая таблицу в консоли
void PrintTable(double[,] Table)
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

//начало программы

double[,] Table = GetTable();
PrintTable(Table);