//Задача 1
//1 запросить у пользователя первое число и сохранить его в переменную1

    static void Main(string[] args)
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        PrintNumbers(n);
    
    static void PrintNumbers(int n)
    
        if (n > 0)
        {
            Console.Write(n + " ");
            PrintNumbers(n - 1);
        }

