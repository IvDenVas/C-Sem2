int num;
while (true)
{
    Console.WriteLine("Введите число: ");
    if (int.TryParse(Console.ReadLine(), out num))
        break;
    Console.WriteLine("Ошибка ввода");
}
int num1 = 0;
int num2 = num;

if ( num > 99 && num < 1000)
{
    num1 = num % 10;
    Console.Write($"{num} -> {num1}");
}
else if (num < 100)
{
    Console.Write($"{num} -> третьей цифры нет");
}
else 
{
    while (num2 > 999)
    {
        num2 = num2 / 10;
        num1 = num2 % 10;
  
    }
Console.Write($"{num} -> {num1}");
}

      

    













