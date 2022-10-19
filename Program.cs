Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

double value = 0;
value = Math.Pow(num1, num2);

Console.WriteLine($"{num1} в степени {num2} = {value}");