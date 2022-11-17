int number;
while (true)
{
    Console.Write("Введите день недели: ");
    if (int.TryParse(Console.ReadLine(), out number))
        if (number > 0 && number <8)
        break;
    Console.WriteLine("Ошибка, в неделе 7 дней!!!!");
}
if (number > 5)
    Console.Write($"{number} -> да");
else
    Console.Write($"{number} -> нет");