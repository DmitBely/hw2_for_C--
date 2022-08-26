// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Write("Введите число дня недели(1-7), чтобы выяснить является ли он выходным: ");
int number = int.Parse(Console.ReadLine());

int monday = 1;
int tuesday = 2;
int wednesday = 3;
int thursday = 4;
int friday = 5; 
int sunday = 6;
int saturday = 7;

if (number == monday ^ number == tuesday ^ number == wednesday ^ number == thursday ^ number == friday )
{
    Console.WriteLine($"{number} день - не выходной");
}
else if (number == sunday ^ number == saturday)
{
    Console.WriteLine($"{number} день - это выходной");
}
else
{
    Console.WriteLine("В неделе лишь семь дней.");
}
