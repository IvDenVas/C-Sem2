int number;
while (true)
{
    Console.WriteLine("Введите трёхзначное число: ");
    if (int.TryParse(Console.ReadLine(), out number))
        if (number > 99 && number <1000)
            break;
    Console.WriteLine("Ошибка ввода");
}

int b = (number / 10) % 10;

Console.Write($"{number} -> {b}");
