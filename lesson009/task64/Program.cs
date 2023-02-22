//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число больше 1:");
int counter = Math.Abs(Convert.ToInt32(Console.ReadLine())); //Исключим ввод отрицательного числа через Math.Abs
if (counter == 0) { Console.WriteLine("Вы ввели не натуральное число!");} // Исключим ввод ноля
else
{
    // Метод вывода натуральных чисел от N до 1:
    void NumberCounter(int counter)
    {
        if (counter == 0) return;
        Console.Write(counter + " ");
        NumberCounter(counter - 1);
    }

    NumberCounter(counter);
}