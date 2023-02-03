//1 запросить у пользователя число и сохранить его в переменную
System.Console.WriteLine("Введите число");
string valueString = Console.ReadLine();
//перевести числj в int
int number = Convert.ToInt32(valueString);
//получить остаток от деления на 2
int remainder = number%2;
//если значение остатка равно 0, то число четное
string NumberType = "нечетное";
if(remainder == 0){
    NumberType = "четное";
}

System.Console.WriteLine($"Число {NumberType}!");

