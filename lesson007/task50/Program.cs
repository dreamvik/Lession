//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//1, 7 -> такого числа в массиве нет
//1, 1 -> 1

//Создание двумерного массива
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

Console.Write("введите номер строки -> ");
string RowNumberStr = Console.ReadLine();
Console.Write("введите номер столбца -> ");
string ColNumberStr = Console.ReadLine();
int RowNumber = Convert.ToInt32(RowNumberStr);
int ColNumber = Convert.ToInt32(ColNumberStr);
double[,] Table = GetTable();
PrintTable(Table);

if (Table.GetLength(0) < RowNumber || Table.GetLength(1) < ColNumber)
{
Console.WriteLine("такого элемента нет");
}
else {
    Console.WriteLine($"Table[{RowNumber},{ColNumber}] = {Table[RowNumber - 1, ColNumber - 1]}");
}
