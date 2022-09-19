// Программа принимает на вход 4 числа и считает среднее арифметическое значение.

Console.WriteLine("Введите чилсо a: ");
double a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите чилсо b: ");
double b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите чилсо c: ");
double c = int.Parse(Console.ReadLine());
Console.WriteLine("Введите чилсо d: ");
double d = int.Parse(Console.ReadLine());

double mean = 0;
mean = (a + b + c + d) / 4;

Console.WriteLine($"Среднее арифметическое значение: {mean,2}");