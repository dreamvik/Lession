//1 запросить у пользователя первое число и сохранить его в переменную1
System.Console.WriteLine("Введите первое число");
string valueString1 = Console.ReadLine();
//2 запросить у пользователя второе число и сохранить его в переменную2
System.Console.WriteLine("Введите второе число");
string valueString2 = Console.ReadLine();
//перевести оба числа в int
int value1 = Convert.ToInt32(valueString1);
int value2 = Convert.ToInt32(valueString2);
//сравнить значения в двух переменных
//если первое значение больше, то вывести Max = переменная 1, Min = переменная 2
//иначе вывести Max = переменная 2, min = переменная 1
if(value1 > value2) {
    System.Console.WriteLine($"Max = {value1}, Min = {value2}");
} else {
   System.Console.WriteLine($"Max = {value2}, Min = {value1}");
}


