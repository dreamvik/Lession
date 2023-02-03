//функция, определяющая четность числа
bool isOrder(int Number){
  int remainder = Number%2;
  return remainder == 0;
}
//1 запросить у пользователя конечное число и сохранить его в переменную
System.Console.WriteLine("Введите последнее число");
string valueString = Console.ReadLine();
//перевести число в int
int N = Convert.ToInt32(valueString);
//для каждого числа от 1 до N проверяем четность и в случае, если оно четное, добавляем к строке
string Numbers = "";
int count = 1;
string separator = "";
while (count <= N)
{
    if (count > 2){
        separator = ", ";
    }
    if (isOrder(count)){
        Numbers = Numbers + separator + count;
    }
    count++;
}

System.Console.WriteLine($"Четные числа: {Numbers}");