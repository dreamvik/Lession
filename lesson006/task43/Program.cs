//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int[] GetCoefficients()
{
    Console.WriteLine("Введите b1 - > ");
    string b1 = Console.ReadLine();
    int B1 = Convert.ToInt32(b1);

    Console.WriteLine("Введите k1 - > ");
    string k1 = Console.ReadLine();
    int K1 = Convert.ToInt32(k1);

    Console.WriteLine("Введите b2 - > ");
    string b2 = Console.ReadLine();
    int B2 = Convert.ToInt32(b2);

    Console.WriteLine("Введите k2 - > ");
    string k2 = Console.ReadLine();
    int K2 = Convert.ToInt32(k2);

    int[] Array = new int[] { B1, K1, B2, K2 };
    return Array;
}
double[] GetCrossPoint(int[] Arr)
{
    double x = (Arr[2] - Arr[0]) / (Arr[1] - Arr[3]);
    double y = Arr[1] * x + Arr[0];
    double[] Array = new double[] { x, y };
    return Array;
}

int[] Coefficients = GetCoefficients();
double[] Coords = GetCrossPoint(Coefficients);
Console.WriteLine ($"b1 = {Coefficients[0]}, k1 = {Coefficients[1]}, b2 = {Coefficients[2]}, k2 = {Coefficients[3]} -> ({Coords[0]}, {Coords[1]})");
