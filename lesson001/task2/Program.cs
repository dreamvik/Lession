//1 запросить у пользователя первое число и сохранить его в переменную1
System.Console.WriteLine("Введите первое число");
string valueString1 = Console.ReadLine();
//2 запросить у пользователя второе число и сохранить его в переменную2
System.Console.WriteLine("Введите второе число");
string valueString2 = Console.ReadLine();
//3 запросить у пользователя третье число и сохранить его в переменную3
System.Console.WriteLine("Введите третье число");
string valueString3 = Console.ReadLine();
//перевести все числа в int
int value1 = Convert.ToInt32(valueString1);
int value2 = Convert.ToInt32(valueString2);
int value3 = Convert.ToInt32(valueString3);
//создать переменную Max и присвоить ей значение первой переменной
int Max = value1;
//если значение второй переменной больше, чем Max, то записываем в Max значение второй переменной
if(value2 > Max){
    Max = value2;
}
//если значение третьей переменной больше, чем Max, то записываем в Max значение третьей переменной
if(value3 > Max){Max = value3;}
//вывести Max

System.Console.WriteLine($"Max = {Max}");

