//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

//функция, возвращающая двумерный массив
int[,] GetTable()
{
    int[,] Table = new int[5, 5];
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

int[,] GetMultiplication(int[,] Table1, int[,] Table2)
{
    int[,] Multiplication = new int[Table1.GetLength(0), Table2.GetLength(1)];
    for (int i = 0; i < Table1.GetLength(0); i++)
    {
        for (int k = 0; k < Table2.GetLength(1); k++)
        {
            int Sum = 0;
            for (int j = 0; j < Table1.GetLength(1); j++)
            {
                Sum = Sum + Table1[i, j] * Table2[j, k];
            }
            Multiplication[i, k] = Sum;
        }

    }
    return Multiplication;
}

//Начало программы

int[,] Table1 = GetTable();
int[,] Table2 = GetTable();
Console.WriteLine("Первая матрица");
PrintTable(Table1);
Console.WriteLine();
Console.WriteLine("Вторая матрица");
PrintTable(Table2);
int[,] Multiplication = GetMultiplication(Table1, Table2);
Console.WriteLine();
Console.WriteLine("произведение матриц");
PrintTable(Multiplication);
