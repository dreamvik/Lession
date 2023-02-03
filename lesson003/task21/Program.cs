//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53
//Запросить у пользователя координаты первой точки
int[] GetCoord(string StringPoint)
{
    string[] ArrayCoordString = StringPoint.Split(new char[] { ',' });
    int[] ArrayCoordInt = new int[3];
    for (int i = 0; i < ArrayCoordString.Length; i++)
    {
        int Number = Convert.ToInt32(ArrayCoordString[i]);
        ArrayCoordInt[i] = Number;
    }
    return ArrayCoordInt;
}
Console.WriteLine("Введите координаты первой точки через запятую");
string Point1 = Console.ReadLine();
int[] Coord1 = GetCoord(Point1);
//Запросить у пользователя координаты второй точки
Console.WriteLine("Введите координаты второй точки через запятую");
string Point2 = Console.ReadLine();
int[] Coord2 = GetCoord(Point2);
double Pow1 = Math.Pow((Coord1[0] - Coord2[0]), 2);
double Pow2 = Math.Pow((Coord1[1] - Coord2[1]), 2);
double Pow3 = Math.Pow((Coord1[2] - Coord2[2]), 2);
double Result = Math.Sqrt(Pow1 + Pow2 + Pow3);
double RoundResult = Math.Round(Result, 2);
Console.WriteLine($"Расстояние между двумя точками A({Coord1[0]}, {Coord1[1]}, {Coord1[2]}) и B({Coord2[0]}, {Coord2[1]}, {Coord2[2]}) будет {RoundResult}");

//