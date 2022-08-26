// Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Введите координаты первой точки:");
Console.Write("x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
Console.Write("x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("y2: ");
int y2 = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2));
Console.WriteLine($"Расстояние между токами равно {distance}");