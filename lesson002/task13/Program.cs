//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//получить у пользователя число
System.Console.WriteLine("Введите любое число");
string Number = Console.ReadLine();
//преобразовать строку в массив символов
char[] Numbers = Number.ToCharArray();
if (Numbers.Length >= 3){
  System.Console.WriteLine($"третье число - {Numbers[2]}");  
} else {
    System.Console.WriteLine("Третьего числа нет");
}
