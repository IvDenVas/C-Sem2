Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if  (num > 99 && num <1000) 
    Console.Write($"{num} -> {num % 10}");
else if (num => 1000)
    Console.Write($"{num} -> {num - ((num / 1000)* 1000)}");