// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти(1-4), чтобы  узнать её диапазон значений: ");
int number = int.Parse(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("Диапазон значений по оси x = 0+, по оси y = 0+");
}

if (number == 2)
{
    Console.WriteLine("Диапазон значений по оси x = 0-, по оси y = 0+");
}

if (number == 3)
{
    Console.WriteLine("Диапазон значений по оси x = 0-, по оси y = 0-");
}

if (number == 4)
{
    Console.WriteLine("Диапазон значений по оси x = 0+, по оси y = 0-");
}
