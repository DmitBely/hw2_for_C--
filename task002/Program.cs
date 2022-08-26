// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Является ли число квадратом другого? Проверим. Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Теперь введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (((number1 * number1) != number2) && ((number2 * number2) != number1))
{
    Console.WriteLine($"Числа {number1} и {number2} не являются корнями друг друга");
}

else if ((number1 * number1) == number2)
{
    Console.WriteLine($"{number2} это квадрат числа {number1}");
}
else if ((number2 * number2) == number1)
{
    Console.WriteLine($"{number1} это квадрат числа {number2}");
}