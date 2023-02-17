// По номеру четверти диапазон значений
Console.Write("Введите номер четверти: ");
int a = int.Parse(Console.ReadLine());
if (a < 1 || a > 4)
{
    Console.WriteLine("Введены некорректные данные. Введите число от 1 до 4");
    return;
}
if (a == 1)
{
    Console.WriteLine("x > 0; y > 0");
}
if (a == 2)
{
    Console.WriteLine("x < 0; y > 0");
}
if (a == 3)
{
    Console.WriteLine("x < 0; y < 0");
}
if (a == 4)
{
    Console.WriteLine("x > 0; y < 0");
}

